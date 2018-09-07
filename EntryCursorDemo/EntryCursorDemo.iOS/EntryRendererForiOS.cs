using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntryCursorDemo;
using EntryCursorDemo.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyEntry), typeof(EntryRendererForiOS))]
namespace EntryCursorDemo.iOS
{
    public class EntryRendererForiOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control.TintColor = UIColor.White;
        }
    }
}