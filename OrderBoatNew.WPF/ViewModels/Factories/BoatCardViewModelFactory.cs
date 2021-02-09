using OrderBoatNew.Domain.Models;
using OrderBoatNew.Domain.Services;

namespace OrderBoatNew.WPF.ViewModels.Factories
{
    public class BoatCardViewModelFactory : IOrderBoatNewViewModelFactory<BoatCardViewModel>
    {
        private readonly IDataService<Model> _modelService;
        private readonly IDataService<Wood> _woodService;
        private readonly IColorService _colorService;
        
        public BoatCardViewModelFactory(IDataService<Model> modelService,
                                        IDataService<Wood> woodService,
                                        IColorService colorService)
        {
            _modelService = modelService;
            _woodService = woodService;
            _colorService = colorService;
        }

        public BoatCardViewModel CreateViewModel()
        {
            return BoatCardViewModel.LoadBoatCardViewModel(_modelService, _woodService, _colorService);
        }
    }
}