using Blauhaus.Forms.Controls.Core.Colours;
using Blauhaus.Forms.Controls.Core.Controls.ActivityIndicatorControls;
using Blauhaus.Forms.Controls.Core.Controls.ButtonControls;
using Blauhaus.Forms.Controls.Core.Controls.CollectionViewControls;
using Blauhaus.Forms.Controls.Core.Controls.EntryControls;
using Blauhaus.Forms.Controls.Core.Controls.FrameControls;
using Blauhaus.Forms.Controls.Core.Controls.GridControls;
using Blauhaus.Forms.Controls.Core.Controls.LabelControls;
using Blauhaus.Forms.Controls.Core.Controls.LayoutControls;
using Blauhaus.Ioc.Abstractions;

namespace Blauhaus.Forms.Controls.Core._Ioc
{
    public static class IocServiceExtensions
    {

        public static IIocService RegisterControls(this IIocService iocService)
        {
            //Labels
            iocService.RegisterType<LabelControl>();
            iocService.RegisterType<StacklayoutControl>();
            iocService.RegisterType<FlexlayoutControl>();
            iocService.RegisterType<EntryControl>();
            iocService.RegisterType<ButtonControl>();
            iocService.RegisterType<CollectionViewControl>();
            iocService.RegisterType<FrameControl>();
            iocService.RegisterType<GridControl>();

            return iocService;
        }

        public static IIocService RegisterMaterialControls<TMaterialPalette>(this IIocService iocService) 
            where TMaterialPalette : class, IMaterialPalette
        {
            iocService.RegisterImplementation<IMaterialPalette, TMaterialPalette>();
            iocService.RegisterType<TMaterialPalette>();
            iocService.RegisterType<ForegroundFrameControl>();
            iocService.RegisterType<PrimaryActivityIndicatorControl>();
            iocService.RegisterType<SecondaryActivityIndicatorControl>();
            iocService.RegisterType<PrimaryButtonControl>();
            iocService.RegisterType<SecondaryButtonControl>();

            iocService.RegisterControls();

            return iocService;
        }
    }
}