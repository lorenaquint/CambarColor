using Xamarin.Forms;

namespace CambioColor
{
    public partial class CambioColorPage : ContentPage
    {
        public CambioColorPage()
        {
            InitializeComponent();
        }

        void CambiarColor(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            var rojo = sldRojo.Value;
            var azul = sldAzul.Value;
            var verde = sldVerde.Value;
            var alpha = sldTrans.Value;
            Color bgColor = new Color(rojo, verde, azul,alpha);
            boxColor.BackgroundColor = bgColor;
            /*lbAzul.Text = azul.ToString();
            lbRojo.Text = rojo.ToString();
            lbVerde.Text = verde.ToString();*/

            lbDisplay.Text = ColorToHex(bgColor);
        }
        private string ColorToHex(Color color)
        {
            int rojo = (int)(color.R * 255);
            int verde = (int)(color.G * 255);
            int azul = (int)(color.B * 255);
            int alpha = (int)(color.A * 255);
            /*lbAzulM.Text = azul.ToString();
            lbRojoM.Text = rojo.ToString();
            lbVerdeM.Text = verde.ToString();*/
            return $"#{rojo:X2}{verde:X2}{azul:X2}{alpha:X2}";
        }
    }
}
