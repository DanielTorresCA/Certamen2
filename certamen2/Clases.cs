using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certamen2
{
    internal class Fecha
    {
        public int Dia { set; get; }
        public int Mes { get; set; }
        public int Anhio { get; set; }
    }

    enum Sexo_t
    {
        Masculino, Femenino

    }

    enum C_conina
    {
        cocinero, ayudante_cocina, receptor_orden
    }
    internal class Trabajador
    {
        private protected int rut;
        private protected int verificador;
        public int Rut { get; set; }
        public int Verificador { get; set; }
        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }

        public Fecha FechaNacimiento { get; set; } = new Fecha();
        public Sexo_t sexo;
    }

    internal class Plato
    {
        public int Identificador { set; get; }
        public string Plato_principal { get; set; }
        public string Postre { get; set; }
        public string Bebida { get; set; }
        public Fecha FechaDeOrden;
        public double Precio { get; set; }
        public double NroMesa { get; set; }
        public Plato(string fecha, int nromesa)
        {
            this.NroMesa = nromesa;
        }
    }

    internal class Mesero : Trabajador
    {
        public double propina;
        public Mesero(string rut,string nombre,string apellido1,string apellido2) { 
            this.rut = Int32.Parse(rut);
            this.Nombre= nombre;
            this.ApellidoPaterno= apellido1;
            this.ApellidoMaterno= apellido2;
        }

        public void AgregarPropina(double precio, double porcentaje)
        {
            this.propina = precio * (porcentaje / 100);
        }
        double ObtenerPropina()
        {
            return this.propina;
        }
    }
    internal class Administrativo : Trabajador
    {
        public string Cargo { get; set; }
    }

    internal class PersonalCocina : Trabajador
    {
        public C_conina Puesto;
    }

}
