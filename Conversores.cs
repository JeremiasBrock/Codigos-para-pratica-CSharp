namespace Conversores;

public class Conversores
{
    public void ConvertAndParse()
    {
        //Maneiras de converter números em formato string para int
        //int numero = int.Parse("1");
        //int numero = Convert.ToInt32("1");
        //Console.WriteLine(numero);

        bool verdadeiro = bool.Parse("True");
        Console.WriteLine(verdadeiro);
    }

    public void AulaTryParse()
    {
        var numero = "123";
        if (int.TryParse(numero, out int numeroConvertido))
        {
            Console.WriteLine("Numero foi convertido com sucesso");
        }

        Console.WriteLine(numeroConvertido);
    }
}