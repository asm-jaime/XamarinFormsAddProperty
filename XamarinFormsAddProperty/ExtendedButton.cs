using Xamarin.Forms;

namespace XamarinFormsAddProperty
{
    public interface IExtendedButton
    {
        Color BackgroundColor { get; set; }
    }

    public class ExtendedButton : Button, IExtendedButton
    {
        public Color BackgroundColor { get; set; }
    }
}
