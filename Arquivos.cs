namespace Arquivos;

public class TrabalhandoComArquivos {

    public void AulaCriandoArquivos(){
        var escrever = new StreamWriter("Cadastro.txt", true);
        Console.WriteLine("Informe o nome da pessoa: ");
        string nome = Console.ReadLine();

        escrever.WriteLine("ID...: " + Random.Shared.Next(1,100));
        escrever.WriteLine("Nome...: " + nome);
        escrever.WriteLine("-------------------");
        escrever.Close();
    }

    public void AulaLendoArquivos(){
        //var conteudo = File.ReadAllText("Cadastro.txt");
        //Console.WriteLine(conteudo);
        var ler = new StreamReader("Cadastro.txt");
        while(!ler.EndOfStream){
            var linha = ler.ReadLine();
            Console.WriteLine(linha);
        }
        ler.Close();
    }

    public void AulaExcluindoArquivos(){
        if (File.Exists("Cadastro.txt")){
            File.Delete("Cadastro.txt");
        }
    }
}