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
        public enum cargos
        {
            Administrativo = 0, Ingeniero = 1, Especialista = 2, Investigador = 3
        };
        private cargos cargo;

        public Empleado (string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngresoLaburo, double sueldoBasico, cargos cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.estadoCivil = estadoCivil;
            this.fechaIngresoLaburo = fechaIngresoLaburo;
            this.sueldoBasico = sueldoBasico;
            this.cargo = cargo;
        }

        

        

    }
}