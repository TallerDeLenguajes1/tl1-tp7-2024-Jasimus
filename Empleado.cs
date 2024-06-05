namespace EspacioEmpleado;

class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fecha_nacimiento = new DateTime();
    private char estado_civil;
    private DateTime fecha_ingreso = new DateTime();
    private double sueldoB;
    private cargos cargo;
    private double adicional;
    private double salario;
    private DateTime fecha_actual;

    public string Nombre {get => nombre; set => nombre = value; }
    public string Apellido {get => apellido; set => apellido = value; }
    public DateTime Fecha_nacimiento {get => fecha_nacimiento; set => fecha_nacimiento = value; }
    public char Estado_civil {get => estado_civil; set => estado_civil = value; }
    public DateTime Fecha_ingreso {get => fecha_ingreso; set => fecha_ingreso = value; }
    public double SueldoB {get => sueldoB; set => sueldoB = value; }
    public cargos Cargo {get => cargo; set => cargo = value; }
    public DateTime Fecha_actual {get => fecha_actual; set => fecha_actual = value; }

    public int Antigüedad(DateTime fechaActual)
    {
        fecha_actual = fechaActual;
        return fechaActual.Year - fecha_ingreso.Year;
    }

    public int Edad(DateTime fechaActual)
    {
        return fechaActual.Year - fecha_nacimiento.Year;
    }

    public int Jubilacion(DateTime fechaActual)
    {
        return 65 - Edad(fechaActual);
    }

    public void Info()
    {
        Console.WriteLine("nombre: "+nombre);
        Console.WriteLine("apellido: "+apellido);
        Console.WriteLine("fecha de nacimiento: "+fecha_nacimiento);
        Console.WriteLine("estado civil: "+estado_civil);
        Console.WriteLine("fecha de ingreso a la empresa: "+fecha_ingreso);
        Console.WriteLine("sueldo básico: "+sueldoB);
        Console.WriteLine("cargo: "+cargo);
    }

    public double Salario()
    {
        if(Antigüedad(fecha_actual) < 20)
        {
            adicional = sueldoB*0.01*Antigüedad(fecha_actual);
        }
        else
        {
            adicional = sueldoB*0.25;
        }

        if(cargo == cargos.ingeniero || cargo == cargos.especialista)
        {
            adicional *= 1.5;
        }

        if(estado_civil.Equals('c'))
        {
            adicional += 150000;
        }

        return sueldoB + adicional;
    }
}
public enum cargos
{
    auxiliar,
    administrativo,
    ingeniero,
    especialista,
    investigador    
}