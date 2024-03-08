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
    historia.Add(new HistoriaJG()
    {
      Id = 1,
      Texto = "tedtsytdydyusadt",
      TemResposta=true,
      TextoDaResposta01="Sim, por favor",
      TextoDaResposta02="Não, estou bem",
      TextoDaResposta03="Para de me encher",
      IdLevelResposta01=2,
      IdLevelResposta02=4998,
      IdLevelResposta03=5000
    });
    historia.Add(new HistoriaJG()
    {
      Id = 2,
      Texto = "SFLKDVHSFDVCVFHJVASA",
      TemResposta=false,
    });
    historia.Add(new HistoriaJG()
    {
      Id = 3,
      Texto = "FGYUDFGHFDHF",
      TemResposta=false,
    });
     historia.Add(new HistoriaJG()
    {
      Id = 4,
      Texto = "DSDSDASDSADSADSAD?",
      TemResposta=false,
    });
    historia.Add(new HistoriaJG()
    {
      Id = 5,
      Texto = "KSHDJHFSJKDFDFSDFDFSD",
      HeroIsDead=true
    });
    historia.Add(new HistoriaJG()
    {
      Id = 4998,
      Texto = "SFJDFSDFHDJHSGDsa",
      TemResposta=false,
    });
    historia.Add(new HistoriaJG()
    {
      Id = 4999,
      Texto = "SADSADSADSADSAD",
      TemResposta=false,
      HeroIsDead=true
    });
    historia.Add(new HistoriaJG()
    {
      Id = 5000,
      Texto = "DSHDSAGDSAHD",
      TemResposta=false,
      HeroIsDead=true
    });

    Iniciar();

	}

   void Iniciar()
  {
    TrocaHistoriaJGatual(0);
  }

  void PreencherPagina()
  {
       textodalabel.Text = HistoriaJGatual.Texto;

    if (HistoriaJGatual.HeroIsDead)
       morte.IsVisible = true;
    else
       morte.IsVisible = false;

    if (HistoriaJGatual.TemResposta)
    {
      next.IsVisible = false;
      buttonResposta01.IsVisible = true;
      buttonResposta02.IsVisible = true;
      buttonResposta03.IsVisible = true;
      buttonResposta01.Text = HistoryStepAtual.TextoDaResposta01;
      buttonResposta02.Text = HistoryStepAtual.TextoDaResposta02;
      buttonResposta03.Text = HistoryStepAtual.TextoDaResposta03;
    }
    else
    {
      next.IsVisible = true;
      buttonResposta01.IsVisible = false;
      buttonResposta02.IsVisible = false;
      buttonResposta03.IsVisible = false;
    }
  }

  void onnext(object sender, EventArgs args)
  {
    var proximoId = HistoriaJG.Id + 1;
    TrocaHistoriaJGatual(proximoId);
  }

  void TrocaHistoriaJGatual(int id)
  {
    HistoriaJG = historia.Where(d => d.Id == id).First();
    PreencherPagina();
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
