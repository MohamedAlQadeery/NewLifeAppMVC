using Mapster;
using Newlife.Web.Core.Models;
using NewLife.Web.Core.ViewModels;

namespace NewLife.Web.Mapping
{
    public class MappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Coach, EditCoachViewModel>()
                .Map(vm => vm.MainImagePreview, c => c.MainImage);
            
          
            

        }
    }
}
