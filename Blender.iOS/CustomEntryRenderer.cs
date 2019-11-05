using System;
using CustomRenderer.iOS;
using Blender;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System.ComponentModel;
using CoreAnimation;
using Foundation;

[assembly: ExportRenderer(typeof(Blender.CustomEntry), typeof(CustomEntryRenderer))]

namespace CustomRenderer.iOS
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderStyle = UITextBorderStyle.None;

                var view = (Element as CustomEntry);

                if (view != null)
                {
                    DrawBorder(view);
                    SetFontSize(view);
                    SetPlaceholderTextColor(view);
                }
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            var view = (CustomEntry)Element;

            if (e.PropertyName.Equals(view.BorderColor))
                DrawBorder(view);
            if (e.PropertyName.Equals(view.FontSize))
                SetFontSize(view);
            if (e.PropertyName.Equals(view.PlaceholderColor))
                SetPlaceholderTextColor(view);
        }

        void DrawBorder(CustomEntry view)
        {
            var borderLayer = new CALayer();
            borderLayer.MasksToBounds = true;
            borderLayer.Frame = new CoreGraphics.CGRect(0f, Frame.Height / 2, Frame.Width, 1f);
            borderLayer.BorderColor = view.BorderColor.ToCGColor();
            borderLayer.BorderWidth = 1.0f;

            Control.Layer.AddSublayer(borderLayer);
            Control.BorderStyle = UITextBorderStyle.None;
        }

        void SetFontSize(CustomEntry view)
        {
            if (view.FontSize != Font.Default.FontSize)
                Control.Font = UIFont.SystemFontOfSize((System.nfloat)view.FontSize);
            else if (view.FontSize == Font.Default.FontSize)
                Control.Font = UIFont.SystemFontOfSize(17f);
        }

        void SetPlaceholderTextColor(CustomEntry view)
        {
            if (string.IsNullOrEmpty(view.Placeholder) == false && view.PlaceholderColor != Color.Default)
            {
                var placeholderString = new NSAttributedString(view.Placeholder,
                                            new UIStringAttributes { ForegroundColor = view.PlaceholderColor.ToUIColor() });
                Control.AttributedPlaceholder = placeholderString;
            }
        }
    }
}

