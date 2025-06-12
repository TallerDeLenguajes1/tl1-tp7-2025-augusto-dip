// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using sisPersonal;

Empleado[] Arreglo = { new Empleado("Roque", "Dip", new DateTime(1963, 12, 21), 'c', new DateTime(2000, 3, 6), 650000, Empleado.Cargos.Ingeniero),
                       new Empleado("Juan Pablo", "Borges", new DateTime(2003, 12, 4), 's', new DateTime(2019, 5, 30), 650000, Empleado.Cargos.Investigador),
                       new Empleado("Martina", "Cespedes", new DateTime(1983, 7, 15), 's', new DateTime(2005, 11, 20), 650000, Empleado.Cargos.Administrativo) };
double totalAPagar = 0;
int i = 0;
int proximoAJubilarse = 0;
foreach (var persona in Arreglo)
{
    Console.WriteLine("\n---------------------------------------------------");
    Console.WriteLine($"Nombre y apellido: {persona.Nombre} {persona.Apellido}");
    int edadDelEmpleado = persona.Edad();
    Console.WriteLine($"Tiene {edadDelEmpleado} años.");
    Console.WriteLine($"Le falta {persona.Jubilarse()} años para jubilarse");
    Console.WriteLine($"Tiene una antiguedad de {persona.Antiguedad()} años");
    Console.WriteLine($"Su sueldo final es de $ {persona.salarioFinal()}");
    Console.WriteLine("---------------------------------------------------");
    totalAPagar += persona.salarioFinal();
    if (persona.Jubilarse() < proximoAJubilarse)
    {
        proximoAJubilarse = i;
    }
    i++;
}

Console.WriteLine($"Se paga en total a todos los empleados ${totalAPagar}");

Console.WriteLine("\n----------------------------------------------------------------------------------");
Console.WriteLine($"La persona q más cerca está de jubilarse es la de índice {proximoAJubilarse} en el arreglo");
Console.WriteLine($"Nombre y apellido: {Arreglo[proximoAJubilarse].Nombre} {Arreglo[proximoAJubilarse].Apellido}");
int edadDelEmpleadoJub = Arreglo[proximoAJubilarse].Edad();
Console.WriteLine($"Tiene {edadDelEmpleadoJub} años.");
Console.WriteLine($"Le falta {Arreglo[proximoAJubilarse].Jubilarse()} años para jubilarse");
Console.WriteLine($"Tiene una antiguedad de {Arreglo[proximoAJubilarse].Antiguedad()} años");
Console.WriteLine($"Su sueldo final es de $ {Arreglo[proximoAJubilarse].salarioFinal()}");
Console.WriteLine("----------------------------------------------------------------------------------");



