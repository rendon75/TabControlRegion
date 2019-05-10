using System;
using Prism.Commands;
using Prism.Mvvm;

namespace TabControlRegion.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand<string> NavigateCommand { get; set; }

        public MainWindowViewModel()
        {
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string navigationPath)
        {
            
        }
    }
}
