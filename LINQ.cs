namespace LINQ;
public class TrabalhandoComLinq
{
    public void AulaWhere()
    {
        /*string nomeCompleto = "FABRICIO JEREMIAS";

        Func<char, bool> filtro = c => c == 'A';

        //var resultado = nomeCompleto.Where(p => p == 'A'); sintex de consulta LAMBDA
        //var resultado = nomeCompleto.Where(filtro); sintex de metodo
        var resultado = from c in nomeCompleto where c == 'A' select c; //sintex de consulta

        foreach(var letra in resultado){
            Console.WriteLine(letra);
        }*/

        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
        var resultado = numeros.Where(p => p >= 10);

        foreach (var item in resultado)
        {
            Console.WriteLine(item);
        }
    }
    public void AulaOrdenacao()
    {
        var nomes = new string[] { "Rafael", "Eduardo", "Bruno" };
        var resultado = nomes.OrderBy(p => p);

        foreach (var item in resultado)
        {
            Console.WriteLine(item);
        }
    }
    public void AulaTake()
    {
        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
        var resultado = numeros.Where(p => p > 10).Take(3).OrderBy(p => p);

        foreach (var item in resultado)
        {
            Console.WriteLine(item);
        }
    }
    public void AulaCount()
    {
        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
        var conta = numeros.Count(p => p > 10);

        Console.WriteLine(conta);
    }

    public void AulaFirst()
    {
        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
        //var conta = numeros.First();
        var conta = numeros.First(p => p > 20);
        Console.WriteLine(conta);
    }
}