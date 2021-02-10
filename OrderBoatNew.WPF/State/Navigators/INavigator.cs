using System.Windows.Input;
using OrderBoatNew.WPF.ViewModels;

namespace OrderBoatNew.WPF.State.Navigators
{
    public enum ViewType
    {
        Boats,
        BoatsAccessory,
        Login
    }
    
    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
    }
}