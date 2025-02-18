namespace Excecao;

public class TrabalhandoComExcecoes
{
    public void AulaGerandoException()
    {

        while (true)
        {
            Console.WriteLine("Informe um numero");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero);
            Console.WriteLine("Resultado: " + resultado);
        }
    }

    public void AulaTratandoException()
    {

        while (true)
        {
            try
            {
                Console.WriteLine("Informe um numero");
                var numero = Console.ReadLine();
                var resultado = 500 / int.Parse(numero);
                Console.WriteLine("Resultado: " + resultado);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("Ocorreu um erro de divisão: " + exception); //Assim eh capaz de informar um erro especifico. 
            }
            catch (Exception exception)
            {
                Console.WriteLine("Ocorreu um erro: " + exception.Message);
                Console.WriteLine("Stack: " + exception.StackTrace);
            }
        }
    }
}