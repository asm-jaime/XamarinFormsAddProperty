using XamarinFormsAddProperty.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsAddProperty;

[assembly: ExportRenderer(typeof(ExtendedButton), typeof(ExtendedButtonRenderer))]
namespace XamarinFormsAddProperty.Droid
{
    public class ExtendedButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null && e.NewElement is IExtendedButton extendedButton)
            {
                //Control.SetBackgroundColor(extendedButton.BackgroundColor.ToAndroid());
                Control.SetBackgroundColor(Color.Blue.ToAndroid());
            }
        }
    }
}