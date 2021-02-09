using System.Windows.Input;
using OrderBoatNew.WPF.ViewModels;

namespace OrderBoatNew.WPF.State.Navigators
{
    public enum ViewType
    {
        Boats,
        BoatsAccessory
    }
    
    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}