// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
using EspacioEmpleado;

// double valor;
// int  oper, seguir;
// string valorS, operS, seguirS;
// Calculadora calc1 = new Calculadora();
// do{
//     Console.WriteLine("valor actual: "+calc1.Resultado);
//     Console.WriteLine("Qué operación desea hacer:\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir");
//     operS = Console.ReadLine();
//     if(int.TryParse(operS, out oper));
//     {
//         do
//         {
//             Console.WriteLine("ingrese el valor a operar: ");
//             valorS = Console.ReadLine();

//         }while(!double.TryParse(valorS, out valor));

//         switch(oper)
//         {
//             case 1:
//                 calc1.Sumar(valor);
//                 break;
//             case 2:
//                 calc1.Restar(valor);
//                 break;
//             case 3:
//                 calc1.Multiplicar(valor);
//                 break;
//             case 4:
//                 calc1.Dividir(valor);
//                 break;
//             default:
//                 break;
//         }
//         Console.WriteLine("valor actual: "+calc1.Resultado);
//     }
//     do 
//     {
//         Console.WriteLine("desea hacer otra operación? 1.SI 0.NO");
//         seguirS = Console.ReadLine();
//     }while(!int.TryParse(seguirS, out seguir));
// }while(seguir!=0);


// Empleado emp1 = new Empleado();
// string nombre, apell, fechaN, fechaI, estadoC, sueldoB, cargoS;
// DateTime fechaNacimiento, fechaIngreso;
// double sueldoBasico;
// int cargo;
// char estadoCivil;

// Console.WriteLine("ingrese el nombre del empleado: ");
// nombre = Console.ReadLine();
// Console.WriteLine("ingrese el apellido del empleado: ");
// apell = Console.ReadLine();

// do
// {
//     Console.WriteLine("ingrese la fecha de nacimiento del empleado (dd/mm/aa): ");
//     fechaN = Console.ReadLine();
// }while(!DateTime.TryParse(fechaN, out fechaNacimiento));

// do
// {
//     Console.WriteLine("estado civil del empleado (soltero = s; casado = c): ");
//     estadoC = Console.ReadLine();
// }while(!char.TryParse(estadoC, out estadoCivil));

// do
// {
//     Console.WriteLine("ingrese la fecha de ingreso del empleado a la empresa (dd/mm/aa): ");
//     fechaI = Console.ReadLine();
// }while(!DateTime.TryParse(fechaI, out fechaIngreso));

// do
// {
//     Console.WriteLine("ingrese el sueldo básico del empleado: ");
//     sueldoB = Console.ReadLine();
// }while(!double.TryParse(sueldoB, out sueldoBasico));

// do
// {
//     Console.WriteLine("elija según el cargo del empleado:\n\t1.Auxiliar\n\t2.Administrativo\n\t3.Ingeniero\n\t4.Especialista\n\t5.Investigador");
//     cargoS = Console.ReadLine();
// }while(!int.TryParse(cargoS, out cargo) || cargo <= 0 || cargo > 5);

// emp1.Nombre = nombre;
// emp1.Apellido = apell;
// emp1.Fecha_nacimiento = fechaNacimiento;
// emp1.Estado_civil = estadoCivil;
// emp1.Fecha_ingreso = fechaIngreso;
// emp1.SueldoB = sueldoBasico;
// switch(cargo)
// {
//     case 1:
//         emp1.Cargo = cargos.auxiliar;
//         break;
//     case 2:
//         emp1.Cargo = cargos.administrativo;
//         break;
//     case 3:
//         emp1.Cargo = cargos.ingeniero;
//         break;
//     case 4:
//         emp1.Cargo = cargos.especialista;
//         break;
//     case 5:
//         emp1.Cargo = cargos.investigador;
//         break;
// }

// emp1.Info();
// DateTime fechaActual = DateTime.Now;
// Console.WriteLine("antigüedad: "+emp1.Antigüedad(fechaActual)+" años");
// Console.WriteLine("Edad: "+emp1.Edad(fechaActual)+" años");
// Console.WriteLine("Cantidad de años para la jubilación: "+emp1.Jubilacion(fechaActual)+" años");
// Console.WriteLine("sueldo: "+emp1.Salario());

Empleado[] empleados = new Empleado[3];
string[] nombres = {"Juan", "Manuel", "Samuel"};
string[] apellidos = {"Medina", "Granda", "Nachio"};
DateTime[] nacimientos = {new DateTime(1993, 5, 21), new DateTime(2001, 3, 14), new DateTime(1996, 10, 2)};
char[] estadosCiviles = {'c', 's', 's'};
DateTime[] ingresos = {new DateTime(2007, 8, 11), new DateTime(2019, 1, 12), new DateTime(2015, 4, 16)};
double[] sueldosB = {65000, 54500, 70300};
cargos[] cargosEmp = {cargos.ingeniero, cargos.auxiliar, cargos.especialista};
double SalarioTotal = 0;
int proximoAJubilarse = 0;
DateTime fechaActual = DateTime.Now;

for (int i=0; i<empleados.Length; i++)
{
    empleados[i] = new Empleado();
    empleados[i].Nombre = nombres[i];
    empleados[i].Apellido = apellidos[i];
    empleados[i].Fecha_nacimiento = nacimientos[i];
    empleados[i].Estado_civil = estadosCiviles[i];
    empleados[i].Fecha_ingreso = ingresos[i];
    empleados[i].SueldoB = sueldosB[i];
    empleados[i].Cargo = cargosEmp[i];
    empleados[i].Fecha_actual = fechaActual;
}

foreach (Empleado emp in empleados)
{
    emp.Info();
    Console.WriteLine();
}

foreach (Empleado emp in empleados)
{
    SalarioTotal += emp.Salario();
}

Console.WriteLine("Monto total en concepto de salarios: ${0}", SalarioTotal);

for (int i=0; i<empleados.Length; i++)
{
    if(empleados[proximoAJubilarse].Jubilacion(fechaActual) > empleados[i].Jubilacion(fechaActual))
    {
        proximoAJubilarse = i;
    }
}
Console.WriteLine();
Console.WriteLine("datos de empleado más próximo a jubilarse: ");
empleados[proximoAJubilarse].Info();
Console.WriteLine("$" + empleados[proximoAJubilarse].Salario());