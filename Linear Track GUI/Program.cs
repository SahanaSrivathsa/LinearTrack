﻿using System;
using System.Windows.Forms;
using Linear_Track_GUI;

namespace Linear_Track_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoadingWindow());
        }
    }
}
