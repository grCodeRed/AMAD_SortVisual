

namespace Sort_Visual;

public static class ColorPicker
{
    //Summary:
    //      this class allows us to set the color of a label to soe defined colors.
    static Dictionary<string, Color> colors = new Dictionary<string, Color> 
    {
        {"sorted", Color.FromArgb("#77ff77") },
        {"lookingAt", Colors.Cyan },
        {"unsorted", Colors.Grey },
        {"current", Colors.Yellow },
        {"best", Colors.Red }
    };

    public static void SetColor(Label label, string key)
    {
        label.BackgroundColor = colors[key];
    }

}
