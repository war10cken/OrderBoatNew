using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using OrderBoatNew.Domain.Models;
using OrderBoatNew.Domain.Services;
using OrderBoatNew.EntityFramework;
using OrderBoatNew.EntityFramework.Services;
using OrderBoatNew.WPF.Commands;

namespace OrderBoatNew.WPF.ViewModels
{
    public class BoatCardViewModel : ViewModelBase
    {
        private readonly IDataService<Model> _modelService;

        private readonly IDataService<Wood> _woodService;

        private readonly IColorService _colorService;

        public string DinghyPath { get; }
        public string SailboatPath { get; } 
        public string GalleyPath { get; }
        
        private bool _isLoading;

        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        private bool _isSelected;

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }

        private List<Model> _models;

        public List<Model> Models
        {
            get => _models;
            set
            {
                _models = value;
                OnPropertyChanged(nameof(Models));
            }
        }

        private List<Wood> _woods;

        public List<Wood> Woods
        {
            get => _woods;
            set
            {
                _woods = value;
                OnPropertyChanged(nameof(Woods));
            }
        }

        private List<Color> _colors;

        public List<Color> Colors
        {
            get => _colors;
            set
            {
                _colors = value;
                OnPropertyChanged(nameof(Colors));
            }
        }

        private List<Color> _colorsForAdditionalPrice;

        public List<Color> ColorsForAdditionalPrice
        {
            get => _colorsForAdditionalPrice;
            set
            {
                _colorsForAdditionalPrice = value;
                OnPropertyChanged(nameof(ColorsForAdditionalPrice));
            }
        }

        public BoatCardViewModel(IDataService<Model> modelService,
                                 IDataService<Wood> woodService,
                                 IColorService colorService)
        {
            _modelService = modelService;
            _woodService = woodService;
            _colorService = colorService;

            DinghyPath = "/Resources/dinghy.jpg";
            SailboatPath = "/Resources/sailboat.jpg";
            GalleyPath = "/Resources/galley.jpg";
            
            LoadComponentsCommand = new LoadBoatComponentsCommand(colorService, woodService, modelService, this);
        }
        
        public ICommand LoadComponentsCommand { get; }

        public static BoatCardViewModel LoadBoatCardViewModel(IDataService<Model> modelService,
                                                              IDataService<Wood> woodService,
                                                              IColorService colorService)
        {
            BoatCardViewModel boatCardViewModel = new BoatCardViewModel(modelService, woodService, colorService);
           
            boatCardViewModel.LoadComponentsCommand.Execute(null);

            return boatCardViewModel;
        }

    }
}