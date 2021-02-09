﻿#nullable enable

using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OrderBoatNew.WPF.Commands
{
    public abstract class AsyncCommandBase : ICommand
    {
        private bool _isExecuting;

        public bool IsExecuting
        {
            get => _isExecuting;
            set
            {
                _isExecuting = value;
                
            }
        }
        
        public virtual bool CanExecute(object? parameter)
        {
            return !IsExecuting;
        }

        public async void Execute(object? parameter)
        {
            IsExecuting = true;

            await ExecuteAsync(parameter);

            IsExecuting = false;
        }

        public abstract Task ExecuteAsync(object parameter);
        
        public event EventHandler? CanExecuteChanged;

        protected void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
        
    }
}