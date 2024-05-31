namespace EspacioCalculadora;

class Calculadora
{
    double resultado = 0;

    public void Sumar(double termino)
    {
        resultado += termino;
    }

    public void Restar(double termino)
    {
        this.resultado -= termino;
    }

    public void Multiplicar(double termino)
    {
        this.resultado *= termino;
    }

    public void Dividir(double termino)
    {
        this.resultado /= termino;
    }

    public void Limpiar()
    {
        this.resultado = 0;
    }

    public double Resultado { get => resultado; }
}




