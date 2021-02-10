using System.ComponentModel;
using System.Runtime.CompilerServices;
using OrderBoatNew.WPF.Models;

namespace OrderBoatNew.WPF.ViewModels
{
    public delegate TViewModel CreateViewModel<out TViewModel>() where TViewModel : ViewModelBase;
    
    public class ViewModelBase : ObservableObject
    {
        
    }
}