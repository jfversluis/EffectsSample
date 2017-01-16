using Android.Graphics;
using Android.Support.V7.Widget;
using EffectsSample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName ("MyCompany")]
[assembly: ExportEffect (typeof (SwitchEffect), "SwitchEffect")]

namespace EffectsSample.Droid
{
    public class SwitchEffect : PlatformEffect
    {
        Xamarin.Forms.Color _trueColor;

        protected override void OnAttached ()
        {
            if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.JellyBean) {
                _trueColor = (Xamarin.Forms.Color)Element.GetValue (SwitchColorEffect.TrueColorProperty);

                ((SwitchCompat)Control).ThumbDrawable.SetColorFilter (_trueColor.ToAndroid (), PorterDuff.Mode.Multiply);
            }
        }

        protected override void OnDetached ()
        {
        }
    }
}
