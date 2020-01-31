﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Reflection;

namespace SharpUpdate
{
    public interface ISharpUpdatable
    {
        string ApplicationName { get; }
        string ApplicationID { get; }
        Assembly ApplicationAssembly { get; }
        Icon ApplicationIcon { get; }
        Uri UpdateXmlLocation { get; }
        Form Context { get; }

        
    }
}
