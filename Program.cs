// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

double valor;
int  oper, seguir;
string valorS, operS, seguirS;
Calculadora calc1 = new Calculadora();
do{
    Console.WriteLine("valor actual: "+calc1.Resultado);
    Console.WriteLine("Qué operación desea hacer:\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir");
    operS = Console.ReadLine();
    if(int.TryParse(operS, out oper));
    {
        do
        {
            Console.WriteLine("ingrese el valor a operar: ");
            valorS = Console.ReadLine();

        }while(!double.TryParse(valorS, out valor));

        switch(oper)
        {
            case 1:
                calc1.Sumar(valor);
                break;
            case 2:
                calc1.Restar(valor);
                break;
            case 3:
                calc1.Multiplicar(valor);
                break;
            case 4:
                calc1.Dividir(valor);
                break;
            default:
                break;
        }
        Console.WriteLine("valor actual: "+calc1.Resultado);
    }
    do 
    {
        Console.WriteLine("desea hacer otra operación? 1.SI 0.NO");
        seguirS = Console.ReadLine();
    }while(!int.TryParse(seguirS, out seguir));
}while(seguir!=0);

