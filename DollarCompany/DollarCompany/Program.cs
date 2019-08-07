﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarCompany
{
    public static class Program
    {
        public static SelectForm selectForm;
        public static SplashScreen splashScreen;
        public static AboutForm aboutForm;
        public static Computer computer;
        public static ProductInfoForm productInfoForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            selectForm = new SelectForm();
            splashScreen = new SplashScreen();
            aboutForm = new AboutForm();
            computer = new Computer();
            productInfoForm = new ProductInfoForm();

            Application.Run(splashScreen);
        }
    }
}
