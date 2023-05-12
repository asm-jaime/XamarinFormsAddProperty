using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsAddProperty;
using XamarinFormsAddProperty.iOS;

[assembly: ExportRenderer(typeof(ExtendedButton), typeof(MyButtonRenderer))]
namespace XamarinFormsAddProperty.iOS
{
    public class MyButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null && e.NewElement is IExtendedButton extendedButton)
            {
                Control.BackgroundColor = extendedButton.BackgroundColor.ToUIColor();
            }
        }
    }
}