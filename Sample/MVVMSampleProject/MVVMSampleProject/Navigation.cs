using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSampleProject
{
    public class Navigation
    {
        private const string MainWindowViewModel = "MVVMSampleProject.MainWindowViewModel";

        public Navigation()
        {
            
        }

        public void Show(object viewModel)
        {
            switch (viewModel.GetType().FullName)
            {
                case MainWindowViewModel:
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
