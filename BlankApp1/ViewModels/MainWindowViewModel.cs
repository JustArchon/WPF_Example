using Microsoft.VisualBasic;
using Prism.Commands;
using Prism.Mvvm;
using System;

namespace BlankApp1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        //private string _title = "Prism Application";
        //public string Title
        //{
        //    get { return _title; }
        //    set { SetProperty(ref _title, value); }
        //}

        public string Title { get; set; } = "Prism Application";
        public DateTime FromDate { get; set; } = DateTime.Now.AddDays(-10);
        public DateTime ToDate { get; set; } = DateTime.Now;


        private DelegateCommand _cmdView;
        public DelegateCommand CmdView =>
            _cmdView ?? (_cmdView = new DelegateCommand(ExecuteCmdView));

        void ExecuteCmdView()
        {
            Title = DateTime.Now.ToString();
            RaisePropertyChanged(nameof(Title));
        }
        
        public MainWindowViewModel()
        {

        }
    }
}
