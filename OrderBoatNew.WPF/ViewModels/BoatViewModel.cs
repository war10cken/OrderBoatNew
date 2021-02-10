using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using OrderBoatNew.Domain.Models;
using OrderBoatNew.Domain.Services;
using OrderBoatNew.EntityFramework.Services;
using OrderBoatNew.EntityFramework;

namespace OrderBoatNew.WPF.ViewModels
{
    public class BoatViewModel : ViewModelBase
    {
        private BoatCardViewModel _boatCardViewModel;

        public BoatCardViewModel BoatCardViewModel
        {
            get => _boatCardViewModel;
            set
            {
                _boatCardViewModel = value;
                OnPropertyChanged(nameof(BoatCardViewModel));
            }
        }
        
        public BoatViewModel(BoatCardViewModel boatCardViewModel)
        {
            BoatCardViewModel = boatCardViewModel;
        }

    }
}