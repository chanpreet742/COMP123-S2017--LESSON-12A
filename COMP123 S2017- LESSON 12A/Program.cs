﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Chanpreet Mudhar
 * Date: August 1, 2017
 * Description: This is a demo application to shocase user interface
 * Version: 0.1- Created the project
 */
namespace COMP123_S2017__LESSON_12A
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
            Application.Run(new Demo());
        }
    }
}
