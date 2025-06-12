namespace sisPersonal
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngresoLaburo;
        private double sueldoBasico;
        public enum Cargos
        {
            Administrativo = 0, Ingeniero = 1, Especialista = 2, Investigador = 3
        };
        private Cargos cargo;

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngresoLaburo, double sueldoBasico, Cargos cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.estadoCivil = estadoCivil;
            this.fechaIngresoLaburo = fechaIngresoLaburo;
            this.sueldoBasico = sueldoBasico;
            this.cargo = cargo;
        }
        public int Edad()
        {
            if (System.DateTime.Today.Month > fechaNacimiento.Month)
            {
                return System.DateTime.Today.Year - fechaNacimiento.Year;
            }
            if (System.DateTime.Today.Month == fechaNacimiento.Month && System.DateTime.Today.Day >= fechaNacimiento.Day)
            {
                return System.DateTime.Today.Year - fechaNacimiento.Year;
            }
            return System.DateTime.Today.Year - fechaNacimiento.Year - 1;
        }

        public int Jubilarse()
        {
            return 65 - Edad();
        }

        public int Antiguedad()
        {
            if (System.DateTime.Today.Month > fechaIngresoLaburo.Month)
            {
                return System.DateTime.Today.Year - fechaIngresoLaburo.Year;
            }
            if (System.DateTime.Today.Month == fechaIngresoLaburo.Month && System.DateTime.Today.Day >= fechaIngresoLaburo.Day)
            {
                return System.DateTime.Today.Year - fechaIngresoLaburo.Year;
            }
            return System.DateTime.Today.Year - fechaIngresoLaburo.Year - 1;
        }

        public double salarioFinal()
        {
            int antiguedad = Antiguedad();
            double adicional;
            if (antiguedad < 20)
            {
                adicional = 0.01 * antiguedad;
            }
            else
            {
                adicional = 0.25;
            }

            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional *= 1.5;
            }
            if (estadoCivil == 'c' || estadoCivil == 'C')
            {
                return sueldoBasico * (1 + adicional) + 150000;
            }
            else
            {
                return sueldoBasico * (1 + adicional);
            }
        }

        public string Nombre { get => nombre; set => nombre = value;}
        public string Apellido { get => apellido; set => apellido = value;}
    }
}