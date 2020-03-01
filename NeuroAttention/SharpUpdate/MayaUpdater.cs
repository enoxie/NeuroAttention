using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SharpUpdate
{
    public class MayaUpdater
    {

        private ISharpUpdatable applicationInfo;
        private BackgroundWorker bgWorker;


        public MayaUpdater(ISharpUpdatable applicationInfo)
        {
            this.applicationInfo = applicationInfo;
            this.bgWorker = new BackgroundWorker();
            this.bgWorker.DoWork += new DoWorkEventHandler(BgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BgWorker_RunWorkerCompleted);
        }

        public void DoUpdate()
        {
            if (!this.bgWorker.IsBusy)
                this.bgWorker.RunWorkerAsync(this.applicationInfo);

        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ISharpUpdatable application = (ISharpUpdatable)e.Argument;

            if (!MayaUpdateXml.ExistOnServer(application.UpdateXmlLocation))
                e.Cancel = true;
            else
                e.Result = MayaUpdateXml.Parse(application.UpdateXmlLocation, application.ApplicationID);

        }
        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (!e.Cancelled)
            {
                MayaUpdateXml update = (MayaUpdateXml)e.Result;

                if(update != null && update.IsNewerThan(this.applicationInfo.ApplicationAssembly.GetName().Version))
                {
                    if (new MayaUpdaterAcceptForm(this.applicationInfo, update).ShowDialog(this.applicationInfo.Context) == DialogResult.Yes)
                        this.DownloadUpdate(update);
                }

                else
                {

                    UpdateOK updateok = new UpdateOK();
                    updateok.Show();
   
                }

            }
            
        }

        private void DownloadUpdate(MayaUpdateXml update)
        {
            MayaUpdaterDownloadForm form = new MayaUpdaterDownloadForm(update.Uri, update.MD5, this.applicationInfo.ApplicationIcon);
            DialogResult result = form.ShowDialog(this.applicationInfo.Context);

            if (result == DialogResult.OK)
            {
                string currentPath = this.applicationInfo.ApplicationAssembly.Location;
                string newPath = Path.GetDirectoryName(currentPath) + "\\" + update.FileName;

                UpdateApplication(form.TempFilePath, currentPath, newPath, update.LaunchArgs);

                Application.Exit();
            }

            else if (result == DialogResult.Abort)
            {
                MessageBox.Show("Güncelleme indirmesi iptal edildi. \nUygulama güncellenemedi.", "MayaUpdater - İndirme İptal Edildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }

            else
            {
                MessageBox.Show("Güncelleme indirilirken bir sorun oluştu. \nLütfen daha sonra tekrar deneyiniz.", "MayaUpdater - Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void UpdateApplication(string tempFilePath, string currentPath, string newPath, string launchArgs)
        {
            string argument = "/C Choice /C Y /N /D Y /T 4 & Del /F /Q \"{0}\" & Choice /C Y /N /D Y /T 2 & Move /Y \"{1}\" \"{2}\" & Start \"\" /D \"{3}\" \"{4}\" {5}";

            ProcessStartInfo info = new ProcessStartInfo();
            info.Arguments = string.Format(argument, currentPath, tempFilePath, newPath, Path.GetDirectoryName(newPath), Path.GetFileName(newPath), launchArgs);
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.FileName = "cmd.exe";
            Process.Start(info);
        }
    }
}
