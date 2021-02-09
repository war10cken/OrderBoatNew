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

    #region OldCode
        // private readonly IDataService<Model> _modelService;
        // private readonly IDataService<Wood> _woodService;
        // private readonly IDataService<Color> _colorService;
        //
        // private List<Model> _models;
        //
        // public List<Model> Models
        // {
        //     get => _models;
        //     set
        //     {
        //         _models = value;
        //         OnPropertyChanged(nameof(Models));
        //     }
        // }
        //
        // private List<string> _woods;
        //
        // public List<string> Woods
        // {
        //     get => _woods;
        //     set
        //     {
        //         _woods = value;
        //         OnPropertyChanged(nameof(Woods));
        //     }
        // }
        //
        // private List<string> _colors;
        //
        // public List<string> Colors
        // {
        //     get => _colors;
        //     set
        //     {
        //         _colors = value;
        //         OnPropertyChanged(nameof(Colors));
        //     }
        // }
        //
        // public BoatViewModel()
        // {
        //     
        // }
        
        // public BoatViewModel(IDataService<Model> modelService,
        //                      IDataService<Wood> woodService,
        //                      IDataService<Color> colorService)
        // {
        //     _modelService = modelService;
        //     _woodService = woodService;
        //     _colorService = colorService;
        // }
        //
        // public static BoatViewModel LoadBoatViewModel()
        // {
        //     var context = new OrderBoatNewDbContextFactory();
        //     
        //     BoatViewModel boatViewModel = new BoatViewModel(new GenericDataService<Model>(context),
        //                                                     new GenericDataService<Wood>(context),
        //                                                     new GenericDataService<Color>(context));
        //     boatViewModel.LoadValues();
        //
        //     return boatViewModel;
        // }
        //
        // private async void LoadValues()
        // {
        //     await _modelService.GetAll().ContinueWith(task =>
        //     {
        //         if (task.Exception == null)
        //             Models = task.Result.ToList();
        //     });
        //
        //     await _woodService.GetAll().ContinueWith(task =>
        //     {
        //         if (task.Exception == null)
        //             Woods = task.Result.Select(w => w.Name).ToList();
        //     });
        //
        //     await _colorService.GetAll().ContinueWith(task =>
        //     {
        //         if (task.Exception == null)
        //             Colors = task.Result.Where(c => c.ForAdditionalMoney == false)
        //                                 .Select(c => c.Name)
        //                                 .ToList();
        //     });
        // }

    #endregion
        
    }
}