using System.ComponentModel;
using System.Windows.Input;
using OrderBoatNew.WPF.Commands;
using OrderBoatNew.WPF.Models;
using OrderBoatNew.WPF.ViewModels;
using OrderBoatNew.WPF.ViewModels.Factories;

namespace OrderBoatNew.WPF.State.Navigators
{
    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand { get; set; }


        public Navigator(IRootOrderBoarNewViewModelFactory viewModelFactory)
        {
            UpdateCurrentViewModelCommand = new UpdateViewModelCommand(this, viewModelFactory);
        }
    }
}