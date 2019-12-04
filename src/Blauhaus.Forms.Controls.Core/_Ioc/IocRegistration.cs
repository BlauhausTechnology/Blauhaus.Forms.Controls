using Blauhaus.Forms.Controls.Core.Controls.EntryControls;
using Blauhaus.Forms.Controls.Core.Controls.LabelControls;
using Blauhaus.Forms.Controls.Core.Controls.LayoutControls;
using Blauhaus.Ioc.Abstractions;

namespace Blauhaus.Forms.Controls.Core._Ioc
{
    public static class IocRegistration
    {
        public static IIocService RegisterControls(this IIocService iocService)
        {
            iocService.RegisterType<LabelControl>();
            iocService.RegisterType<StacklayoutControl>();
            iocService.RegisterType<FlexlayoutControl>();
            iocService.RegisterType<EntryControl>();

            return iocService;
        }
    }
}