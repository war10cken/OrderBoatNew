#nullable enable

using System;
using System.Windows.Input;
using OrderBoatNew.WPF.State.Navigators;
using OrderBoatNew.WPF.ViewModels.Factories;

namespace OrderBoatNew.WPF.Commands
{
    public class UpdateViewModelCommand : ICommand
    {
        private readonly INavigator _navigator;
        private readonly IOrderBoarNewViewModelFactory _viewModelFactory;

        public UpdateViewModelCommand(INavigator navigator, IOrderBoarNewViewModelFactory viewModelFactory)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is ViewType viewType)
            {
                _navigator.CurrentViewModel = _viewModelFactory.CreateViewModel(viewType);
            }
        }

        public event EventHandler? CanExecuteChanged;
    }
}