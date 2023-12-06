﻿using BusinessManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjc2MTM0OUAzMjMzMmUzMDJlMzBLYnRmRWVsUDlMcXpYYlNrc3hVNC9jNHM5c2hCTWVEWGgxT2oyUnM2Qm9BPQ==");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
          //  Application.Run(new LoginView());
        }
    }
}
