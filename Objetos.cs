using System.Runtime.InteropServices.Marshalling;

namespace Cadastro
{
    public static class Calculos
    {

        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }
    }

    public class Produto
    {

        private int Id;
        public string descricao { get; set; }
        public int estoque { get; }

        public Produto()
        {
            estoque = 5;
        }

        public void ImprimirDesc()
        {
            Console.WriteLine(GetId() + " - " + descricao);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }


    }

    public class Pessoa
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Código: " + Id);
            Console.WriteLine("Endereco: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("Cep: " + Cep);
        }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public void ImprimirCpf()
        {
            Console.WriteLine("CPF: " + CPF);
        }
    }

    public class Funcionario : PessoaFisica
    {
        public string Matricula { get; set; }
    }

    public sealed class Configuracao
    {
        public string Host { get; set; }
    }

    public abstract class Animais
    {
        public string Nome { get; set; }
        public abstract string GetInformacoes();
        public void ImprimirInformacoes()
        {
            Console.WriteLine("Nome animal: " + Nome);
            Console.WriteLine("Informacoes: " + GetInformacoes());
        }
    }

    public class Cachorro : Animais
    {
        public override string GetInformacoes()
        {
            return "Cachorro é um bom amigo";
        }
    }

    public class Curso
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (obj is Curso curso)
            {
                return Id == curso.Id && curso.Descricao == curso.Descricao;
            }
            return base.Equals(obj);
        }

        public static bool operator ==(Curso a, Curso b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Curso a, Curso b)
        {
            return a.Equals(b);
        }
    }

    public record CursoRecord(int Id, string Descricao);

    public class CursoTeste
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }

    public interface INotificacao
    {
        string Descricao { get; set; }
        void Notificar();
    }

    public class NotificacaoCliente : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando cliente");
        }
        public void NotificarOutros()
        {
            Console.WriteLine("Notificando outross");
        }
    }

    public class NotificacaoFuncionario : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando funcionario");
        }

        public void NotificarOutros()
        {
            Console.WriteLine("Notificando outross");
        }
    }
}