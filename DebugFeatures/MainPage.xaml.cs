namespace DebugFeatures
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void ButtonClicked(object sender, EventArgs e) => Btn.Text = "Pressed";
	}
}