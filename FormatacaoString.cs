namespace FormatacaoString;
public class TrabalhandoComStrings
{
    public void ConverterParaLetrasMinusculas()
    {
        Console.Write("Favor digitar alguma informacao:");
        var linha = Console.ReadLine();
        Console.Write(linha.ToLower());
    }
    public void ConverterParaLetrasMaisculas()
    {
        Console.Write("Favor digitar alguma informacao:");
        var linha = Console.ReadLine();
        Console.Write(linha.ToUpper());

    }
    public void AulaSubstring()
    {
        Console.Write("Favor digitar alguma informacao:");
        var linha = Console.ReadLine();
        Console.Write(linha.Substring(3, 8));
    }
    public void AulaRange()
    {
        string nomeArquivo = "2022_12_01.backup.bak";
        string ano = nomeArquivo[..4];
        Console.WriteLine(ano);
        string extensao = nomeArquivo[^3..];
        Console.WriteLine(extensao);
        string nome = nomeArquivo[11..^4];
        Console.WriteLine(nome);
        string nomeCompleto = nomeArquivo[..^4];
        Console.WriteLine(nomeCompleto);
    }
    public void AulaContains()
    {
        string nomeArquivo = "2022_12_01.backup.bak";

        if (nomeArquivo.Contains("arco"))
        {
            Console.WriteLine("Palavra encontrada");
        }
        else
        {
            Console.WriteLine("Palavra não encontrada");
        }
        //Console.WriteLine("Contem nome: " + nomeArquivo.Contains("arco"));
    }
    public void AulaTrim()
    {
        string teste = "** . Fabricio Jeremias  *";
        //Console.WriteLine(teste.Trim('*'));
        //Console.WriteLine(teste.TrimStart('*'));
        //Console.WriteLine(teste.TrimEnd('*'));
        //Console.WriteLine(teste.Trim('.').TrimStart('*','*').TrimEnd('*'));
        Console.WriteLine(teste.Trim('*', '.', ' '));
    }
    public void AulaStartAndEnds()
    {
        string teste = "Curso Csharp";
        Console.WriteLine(teste.StartsWith("Curso"));
        Console.WriteLine(teste.EndsWith("Csharp02"));

        if (teste.StartsWith("Curso"))
        {
            Console.WriteLine("Palavra começa com 'Curso'");
        }
        else
        {
            Console.WriteLine("Palavra não começa com 'Curso'");
        }
    }
    public void AulaReplace()
    {
        string teste = "Curso Csharp";
        Console.WriteLine(teste);
        Console.WriteLine(teste.Replace("Csharp", "C#"));
    }
    public void AulaLenght()
    {
        string teste = "Curso Csharp";
        Console.WriteLine(teste);
        Console.WriteLine(teste.Length);
    }
}
