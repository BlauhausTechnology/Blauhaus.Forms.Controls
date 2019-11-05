using Blauhaus.Forms.Controls.Core.LabelControls;
using Blauhaus.Ioc.Abstractions;

namespace Blauhaus.Forms.Controls.Core._Ioc
{
    public static class IocRegistration
    {
        public static IIocService RegisterControls(this IIocService iocService)
        {
            iocService.RegisterType<LabelControl>();
            return iocService;
        }
    }
}