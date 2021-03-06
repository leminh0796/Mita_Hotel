﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lemon3;
using Mita_Coffee.Views;
using Mita_Coffee;

namespace Mita_Coffee
{
    class Mita_setup
    {
        [STAThread]
        public static void Main()
        {
            Setdefault();
            D00F0000 frm = new D00F0000();  //Call the Login Form
            frm.ShowDialog();
            if (frm.LoginSuccess)   //Check if login success
            {
                MainWindow Main = new MainWindow();     //Access to Main Window
                Main.WindowState = System.Windows.WindowState.Maximized;
                Main.ShowDialog();
            }
        }
        private static void Setdefault()    //Default Application's Settings
        {
            L3.ModuleIDRunning = "DA1";
            L3.IsUniCode = true;
            L3.Language = EnumLanguage.Vietnamese;
            L3.STRLanguage = "84";
            L3.ApplicationPath = Environment.CurrentDirectory;
            L3.ApplicationSetup = L3.ApplicationPath;
            L3.Server = Properties.Settings.Default.MitaServer;
            //L3.Server = @"DESKTOP-U8A8UHB\SQL2012"; //Default Server name
            L3.ConnectionUser = Properties.Settings.Default.MitaLogin;
            L3.Password = Properties.Settings.Default.MitaPassword;
            L3.CompanyID = Properties.Settings.Default.MitaDB;
            L3.UserID = "ADMIN";
            L3.ConnectionString = "Data Source=" + L3.Server + ";Initial Catalog=" + L3.CompanyID + ";User ID=" + L3.ConnectionUser + ";Password=" + L3.Password + ";Connect Timeout = 5";
        }
    }
}
