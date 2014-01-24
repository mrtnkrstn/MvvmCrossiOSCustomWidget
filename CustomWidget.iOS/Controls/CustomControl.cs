using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using CustomWidget.Core.ViewModels;

namespace CustomWidget.iOS.Controls
{
	public partial class CustomControl : MvxView
	{
//		public UILabel Label
//		{
//			get {
//				return this.label;
//			}
//		}
//
//		public UIButton Button
//		{
//			get {
//				return this.button;
//			}
//		}

		public static readonly UINib Nib = UINib.FromName ("CustomControl", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("CustomControl");

		public CustomControl (IntPtr handle) : base (handle)
		{
			this.DelayBind (() => {
				var set = this.CreateBindingSet<CustomControl, FirstViewModel>();
				set.Bind(label).To(vm => vm.Label);
				set.Bind(button).To(vm => vm.ChangeTextCommand);
				set.Apply();
			});
		}

		public static CustomControl Create ()
		{
			return (CustomControl)Nib.Instantiate (null, null) [0];
		}
	}
}

