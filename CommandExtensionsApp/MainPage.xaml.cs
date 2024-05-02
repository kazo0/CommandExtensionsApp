namespace CommandExtensionsApp;

public sealed partial class MainPage : Page
{
	public MainPage()
	{
		this.InitializeComponent();

		this.DataContext = new BindableMainModel();
	}
}
