namespace gusta;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void IrParaJogo (object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new GamePage();
  }
  

  
}

