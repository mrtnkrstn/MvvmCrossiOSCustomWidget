using Cirrious.MvvmCross.ViewModels;

namespace CustomWidget.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private bool state = false;

		private string _label = "Hello MvvmCross";
        public string Label
		{ 
			get { return _label; }
			set { _label = value; RaisePropertyChanged(() => Label); }
		}

		private MvxCommand _changeTextCommand;
		public System.Windows.Input.ICommand ChangeTextCommand
		{
			get
			{
				_changeTextCommand = _changeTextCommand ?? new MvxCommand(ChangeText);
				return _changeTextCommand;
			}
		}

		private void ChangeText()
		{
			if (!state) {
				Label = "Hello MvvmCross";
			} else {
				Label = "Goodbye MvvmCross";
			}

			state = !state;
		}
    }
}
