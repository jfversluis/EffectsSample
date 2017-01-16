using EffectsSample.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName ("MyCompany")]
[assembly: ExportEffect (typeof (SwitchEffect), "SwitchEffect")]
namespace EffectsSample.iOS
{
    public class SwitchEffect : PlatformEffect
    {
        Xamarin.Forms.Color _trueColor;

        protected override void OnAttached ()
        {
            _trueColor = (Xamarin.Forms.Color)Element.GetValue (SwitchColorEffect.TrueColorProperty);
            (Control as UISwitch).OnTintColor = _trueColor.ToUIColor ();
        }

        protected override void OnDetached ()
        {
        }
    }
}