namespace EspacioCalculadora;

class Calculadora
{
    double resultado = 0;

    void Sumar(double termino)
    {
        string term;
        Console.writeLine("ingrese el valor a sumar: ");
        term = Console.ReadLine();
        if(double.TryParce(term, out termino))
        {
            this.resultado += termino;
        }
    }

    void Restar(double termino)
    {
        string term;
        Console.writeLine("ingrese el valor a restar: ");
        term = Console.ReadLine();
        if(double.TryParce(term, out termino))
        {
            this.resultado -= termino;
        }
    }

    void Multiplicar(double termino)
    {
        string term;
        Console.writeLine("ingrese el valor a multiplicar: ");
        term = Console.ReadLine();
        if(double.TryParce(term, out termino))
        {
            this.resultado *= termino;
        }
    }

    void Dividir(double termino)
    {
        string term;
        Console.writeLine("ingrese el valor por el cual dividir: ");
        term = Console.ReadLine();
        if(double.TryParce(term, out termino))
        {
            this.resultado /= termino;
        }
    }

    void Limpiar()
    {
        this.resultado = 0;
    }

    public global::System.String Resultado { get => resultado; }
}




