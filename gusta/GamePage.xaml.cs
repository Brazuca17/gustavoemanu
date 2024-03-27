namespace gusta;

public partial class GamePage : ContentPage
{
   List<HistoriaJG> historia = new List<HistoriaJG>();
  HistoriaJG HistoriaJGatual;

public GamePage()
	{
		InitializeComponent();

    historia.Add(new HistoriaJG()
    {
      Id = 0,
      Texto = "ola viajante",
      TemResposta=false
    }); 
    
   void Iniciar()
  {
    TrocaHistoriaJGatual(0);
  }

 
  void onnext(object sender, EventArgs args)
  {
    var proximoId = HistoriaJG.Id + 1;
    TrocaHistoriaJGatual(proximoId);
  }
  
  void OnButton01Clicked(object sender, EventArgs args)
  {
    TrocaHistoriaJGatual(HistoriaJGatual.IdLevelResposta01);
  }

   void OnButton02Clicked(object sender, EventArgs args)
  {
    TrocaHistoriaJGatual(HistoriaJGatual.IdLevelResposta02);
  }
  void OnButton03Clicked(object sender, EventArgs args)
  {
    TrocaHistoriaJGatual(HistoriaJGatual.IdLevelResposta03);
  }
private void voltarmenu (object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new MainPage();
  }

  void perdeu(object sender, EventArgs args)
  {
    Iniciar();
  }
  
}
