using System;
using System.Windows.Input;
using OrderBoatNew.WPF.State.Navigators;

namespace OrderBoatNew.WPF.Commands
{
    public class RenavigateCommand : ICommand
    {
        private readonly IRenavigator _renavigator;

        public RenavigateCommand(IRenavigator renavigator)
        {
            _renavigator = renavigator;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _renavigator.Renavigate();
        }

        public event EventHandler? CanExecuteChanged;
    }
}