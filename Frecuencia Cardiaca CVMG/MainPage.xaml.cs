namespace Frecuencia_Cardiaca_CVMG
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCalcularClicked(object sender, EventArgs e)
		{

			if (!int.TryParse(txtLatidos.Text, out int latidos) ||
				latidos < 0)
			{
				lblResultado.Text = "Ingresa una cantidad válida.";
				return;
			}

			int frecuencia = latidos * 4;

			if (frecuencia < 60)
			{
				lblResultado.Text =
					$"Frecuencia: {frecuencia} latidos por minuto\n" +
					"Frecuencia cardíaca baja";
			}
			else if (frecuencia > 100)
			{
				lblResultado.Text =
					$"Frecuencia: {frecuencia} latidos por minuto\n" +
					"Frecuencia cardíaca alta";
			}
			else
			{
				lblResultado.Text =
					$"Frecuencia: {frecuencia} latidos por minuto\n" +
					"Frecuencia cardíaca normal";
			}
		}
	}
}
