using System.Linq;
using Xamarin.Forms;

namespace EffectsSample
{
    public static class SwitchColorEffect
    {
        public static readonly BindableProperty TrueColorProperty = BindableProperty.CreateAttached ("TrueColor", typeof (Color), typeof (SwitchColorEffect), Color.Transparent, propertyChanged: OnColorChanged);

        private static void OnColorChanged (BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as Switch;
            if (control == null)
                return;

            var color = (Color)newValue;

            var attachedEffect = control.Effects.FirstOrDefault (e => e is SwitchEffect);
            if (color != Color.Transparent && attachedEffect == null)
                control.Effects.Add (new SwitchEffect ());
            else if (color == Color.Transparent && attachedEffect != null)
                control.Effects.Remove (attachedEffect);
        }

        public static Color GetTrueColor (BindableObject view)
        {
            return (Color)view.GetValue (TrueColorProperty);
        }

        public static void SetTrueColor (BindableObject view, Color color)
        {
            view.SetValue (TrueColorProperty, color);
        }
    }
}
