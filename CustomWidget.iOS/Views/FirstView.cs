using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using CustomWidget.iOS.Controls;

namespace CustomWidget.iOS.Views
{
    [Register("FirstView")]
    public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
			View = new UIView(){ BackgroundColor = UIColor.White };
            base.ViewDidLoad();

			// ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
               EdgesForExtendedLayout = UIRectEdge.None;
			   
			var ctrl = CustomControl.Create ();
			Add (ctrl);

//            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
//			set.Bind(ctrl).For(c => c.Label).To(vm => vm.Label);
//			set.Bind(ctrl).For(c => c.Button).To(vm => vm.ChangeTextCommand);
//
//            set.Apply();
        }
    }
}