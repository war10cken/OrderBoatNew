using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using OrderBoatNew.Domain.Models;
using OrderBoatNew.Domain.Services;
using OrderBoatNew.WPF.ViewModels;

namespace OrderBoatNew.WPF.Commands
{
    public class LoadBoatComponentsCommand : AsyncCommandBase
    {
        private readonly BoatCardViewModel _boatCardViewModel;
        private readonly IDataService<Model> _modelService;
        private readonly IDataService<Wood> _woodService;
        private readonly IColorService _colorService;
        public LoadBoatComponentsCommand(IColorService colorService,
                                         IDataService<Wood> woodService,
                                         IDataService<Model> modelService,
                                         BoatCardViewModel boatCardViewModel)
        {
            _colorService = colorService;
            _woodService = woodService;
            _modelService = modelService;
            _boatCardViewModel = boatCardViewModel;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _boatCardViewModel.IsLoading = true;

            await Task.WhenAll(LoadModels(), LoadWoods(), LoadColors());
        }

        private async Task LoadModels()
        {
            _boatCardViewModel.Models = await _modelService.GetAll() as List<Model>;
        }

        private async Task LoadWoods()
        {
            _boatCardViewModel.Woods = await _woodService.GetAll() as List<Wood>;
        }

        private async Task LoadColors()
        {
            _boatCardViewModel.Colors = await _colorService.GetFreeColor() as List<Color>;
            _boatCardViewModel.ColorsForAdditionalPrice =
                await _colorService.GetColorForAdditionalPrice() as List<Color>;
        }
    }
}