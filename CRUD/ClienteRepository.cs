using Cadastro;

namespace Repositorio;

public class ClienteRepositorio
{
    public List<Cliente> clientes = new List<Cliente>();

    public void GravarDadosClientes()
    {
        var json = System.Text.Json.JsonSerializer.Serialize(clientes);

        File.WriteAllText("clientes.txt", json);
    }

    public void LerDadosClientes()
    {
        if(File.Exists("clientes.txt"))
        {
        var dados = File.ReadAllText("clientes.txt");
        var clientesArquivo = System.Text.Json.JsonSerializer.Deserialize<List<Cliente>>(dados);
        clientes.AddRange(clientesArquivo);
        }
    }

    public void ImprimirCliente(Cliente cliente)
    {
        Console.WriteLine("Id:  " + cliente.Id);
        Console.WriteLine("Nome:  " + cliente.Nome);
        Console.WriteLine("Desconto:  " + cliente.Desconto);
        Console.WriteLine("Data Nascimento:  " + cliente.DataNascimento);
        Console.WriteLine("Data Cadastro:  " + cliente.CadastroEm);
        Console.WriteLine("------------------");
    }

    public void ExibirClientes()
    {
        Console.Clear();
        foreach (var cliente in clientes)
        {
            ImprimirCliente(cliente);
        }
        Console.ReadKey();
    }

    public void CadastrarCliente()
    {
        Console.Clear();

        Console.WriteLine("Nome do cliente: ");
        var nome = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("Data de nascimento: ");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.WriteLine("Desconto: ");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        var cliente = new Cliente();
        cliente.Id = clientes.Count + 1;
        cliente.Nome = nome;
        cliente.DataNascimento = dataNascimento;
        cliente.Desconto = desconto;
        cliente.CadastroEm = DateTime.Now;

        clientes.Add(cliente);

        Console.WriteLine("Cliente cadastrado com sucesso!");
        ImprimirCliente(cliente);
        Console.ReadKey();
    }

    public void EditarCliente()
    {
        Console.Clear();
        Console.WriteLine("Informe o código do cliente: ");
        var codigo = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado.");
            Console.ReadKey();
            return;
        }

        ImprimirCliente(cliente);

        Console.WriteLine("Nome do cliente: ");
        var nome = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("Data de nascimento: ");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.WriteLine("Desconto: ");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        cliente.Nome = nome;
        cliente.DataNascimento = dataNascimento;
        cliente.Desconto = desconto;
        cliente.CadastroEm = DateTime.Now;

        Console.WriteLine("Cliente editado com sucesso!");
        ImprimirCliente(cliente);
        Console.ReadKey();
    }

    public void ExcluirCliente()
    {
        Console.Clear();
        Console.WriteLine("Informe o código do cliente: ");
        var codigo = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado.");
            Console.ReadKey();
            return;
        }

        ImprimirCliente(cliente);
        clientes.Remove(cliente);
        Console.WriteLine("Cliente removido com sucesso!");
        Console.ReadKey();
    }
}