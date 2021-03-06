﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMSampleProject
{
    public class Navigation
    {
        private const string AddDebtorViewModel = "MVVMSampleProject.viewmodel.AddDebtorViewModel";

        public Navigation()
        {
            
        }

        public void Show(object viewModel)
        {
            switch (viewModel.GetType().FullName)
            {
                case AddDebtorViewModel:
                    var debtorWindow = new AddDebtorWindow(); 
                    var window = new Window()
                    {
                        Title = "DebtorView",
                        Content = debtorWindow,
                    };
                    window.Show();

                    /* TO DO: 
                     *  Create new user control based on type of viewmodel
                     *  Make a new window with that user control
                     * Show window
                     */
                    break;
            }
        }
    }
}
