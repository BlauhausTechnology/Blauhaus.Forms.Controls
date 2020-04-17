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
using Microsoft.Extensions.DependencyInjection;

namespace Blauhaus.Forms.Controls.Core._Ioc
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection RegisterControls(this IServiceCollection services)
        {
            //Labels
            services.AddTransient<LabelControl>();
            services.AddTransient<StacklayoutControl>();
            services.AddTransient<FlexlayoutControl>();
            services.AddTransient<EntryControl>();
            services.AddTransient<ButtonControl>();
            services.AddTransient<CollectionViewControl>();
            services.AddTransient<FrameControl>();
            services.AddTransient<GridControl>();

            return services;
        }

        public static IServiceCollection RegisterMaterialControls<TMaterialPalette>(this IServiceCollection iocService) 
            where TMaterialPalette : class, IMaterialPalette
        {
            iocService.AddSingleton<IMaterialPalette, TMaterialPalette>();
            iocService.AddTransient<TMaterialPalette>();
            iocService.AddTransient<ForegroundFrameControl>();
            iocService.AddTransient<PrimaryActivityIndicatorControl>();
            iocService.AddTransient<SecondaryActivityIndicatorControl>();
            iocService.AddTransient<PrimaryButtonControl>();
            iocService.AddTransient<SecondaryButtonControl>();

            iocService.RegisterControls();

            return iocService;
        }
    }
}