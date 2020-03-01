using System;
using System.Windows.Forms;

namespace SharpUpdate
{
    internal partial class MayaUpdaterAcceptForm : Form
    {

        private ISharpUpdatable applicationInfo;
        private MayaUpdateXml updateInfo;
        private MayaUpdaterInfoForm updateInfoForm;
        
    


        internal MayaUpdaterAcceptForm(ISharpUpdatable applicationInfo, MayaUpdateXml updateInfo)
        {
            InitializeComponent();

            this.applicationInfo = applicationInfo;
            this.updateInfo = updateInfo;

            this.Text = "MayaUpdater" + " - Güncelleme Mevcut";

          

            this.lblNewVersion.Text = string.Format("Yeni Sürüm: {0}", this.updateInfo.Version.ToString());

           

            this.lbl_currentVersion.Text = String.Format("Eski Sürüm: {0}\nUpdate Version : {1}", applicationInfo.ApplicationAssembly.GetName().Version.ToString(),
                updateInfo.Version.ToString());
            this.lbl_updateinfo.Text = updateInfo.Description;


        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
            Application.Restart();
            
            
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (this.updateInfoForm == null)
                this.updateInfoForm = new MayaUpdaterInfoForm(this.applicationInfo, this.updateInfo);

            this.updateInfoForm.ShowDialog(this);
        }

      
    }
}
