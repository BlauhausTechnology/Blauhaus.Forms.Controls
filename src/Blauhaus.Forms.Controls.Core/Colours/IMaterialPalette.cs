using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Colours
{
    public interface IMaterialPalette
    {
        Color AppBackground { get; }
        Color AppBackgroundOffset { get; }

        Color AppForeground { get; }
        Color AppForegroundOffset { get; }
        Color AppForegroundOffsetLight { get; }

        Color Primary { get; }
        Color PrimaryLight { get; }
        Color PrimaryDark { get; }
        Color PrimaryText { get; }

        Color Secondary { get; }
        Color SecondaryLight { get; }
        Color SecondaryDark { get; }
        Color SecondaryText { get; }
    }
}