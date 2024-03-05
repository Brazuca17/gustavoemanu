namespace gusta;

public partial class GamePage : ContentPage
{


public GamePage()
	{
		InitializeComponent();
	}
 
private void voltarmenu (object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new MainPage();
  }

}
