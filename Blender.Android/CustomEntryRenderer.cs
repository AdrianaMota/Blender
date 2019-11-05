using System;
using Blender;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using Android.Text;
using Android.Content.Res;
using Blender.Droid;
using Android.Graphics;

namespace Blender.Droid
{
    [Obsolete]
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control == null || Element == null || e.OldElement != null) return;

            var element = (CustomEntry)Element;
            var ourCustomColorHere = element.BorderColor.ToAndroid();
            Control.Background.SetColorFilter(ourCustomColorHere, PorterDuff.Mode.SrcAtop);
        }
    }
}

