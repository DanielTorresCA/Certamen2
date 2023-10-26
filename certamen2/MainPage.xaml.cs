namespace certamen2
{
    
    public partial class MainPage : ContentPage
    {
        
        List<Mesero> lista_de_meseros = new List<Mesero>();
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void Boton_maestro_Clicked(object sender, EventArgs e)
        {
            string rutingresado = Rut.Text;
            string nombre_ingresado = Nombre.Text;
            string apellido_paterno = Ap_pat.Text;
            string apellido_materno = Ap_mat.Text;

            rellenar_mesero(rutingresado, nombre_ingresado,apellido_paterno,apellido_materno);

            DisplayAlert("mesero agergado con exito","por favor no espamear","aceptar","cancelar");
        }

        public void rellenar_mesero(string rutmesero,string nombremesero,string apellidopat,string apelidomat)
        {
            Mesero MeseroARellenar =new Mesero(rutmesero, nombremesero, apellidopat, apelidomat);
            lista_de_meseros.Add(MeseroARellenar);
        }
    }
}