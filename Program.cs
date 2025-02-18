using System;
using System.Runtime.CompilerServices;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            //AulaClasses();
            //AulaHeranca();
            //ClasseSelada();
            //ClasseAbstrada();
            //AulaRecord();
            //AulaInterface();
            //Conversores();
            //TrabalhandoComStrings();
            //FormatacaoDatas();
            //TrabalhandoComExcecoes();
            //TrabalhandoComArquivos();
            TrabalhandoComLinq();

        }

        private static void AulaClasses()
        {
            var resultado = Cadastro.Calculos.SomarNumeros(2, 3);
            Console.WriteLine(resultado);

            var produto = new Cadastro.Produto();
            produto.SetId(1);
            produto.descricao = "Teclado";
            produto.ImprimirDesc();
            Console.WriteLine(produto.GetId());
            Console.WriteLine(produto.estoque);
        }

        private static void AulaHeranca()
        {
            var pessoaFisica = new Cadastro.PessoaFisica();
            pessoaFisica.Id = 1;
            pessoaFisica.Cep = "123123123";
            pessoaFisica.Cidade = "Cidade teste";
            pessoaFisica.Endereco = "Endereco teste";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCpf();

            var funcionario = new Cadastro.PessoaFisica();
            pessoaFisica.Id = 2;
            pessoaFisica.Cep = "232323";
            pessoaFisica.Cidade = "Cidade teste2";
            pessoaFisica.Endereco = "Endereco teste2";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCpf();
        }

        private static void ClasseSelada()
        {
            var configuracao = new Cadastro.Configuracao
            {
                Host = "localhost"
            };
            Console.WriteLine(configuracao.Host);
        }

        private static void ClasseAbstrada()
        {
            var animal = new Cadastro.Cachorro();
            animal.Nome = "Rex";
            animal.ImprimirInformacoes();
        }

        private static void AulaRecord()
        {
            /* var curso = new Cadastro.Curso{ Id = 1, Descricao = "Curso"};
             var curso2 = new Cadastro.Curso{ Id = 1, Descricao = "Curso"};

             Console.WriteLine(curso.Equals(curso2))
             Console.WriteLine(curso == curso2);

             var curso = new Cadastro.CursoRecord(1, "Curso");
             var curso1 = new Cadastro.CursoRecord(1, "Curso");
             Console.WriteLine(curso == curso1);

             var cursoTeste = new Cadastro.CursoTeste{Id = 1, Descricao = "Curso"};
             var cursoTeste2 = cursoTeste;
             cursoTeste2.Descricao = "teste";
             Console.WriteLine(cursoTeste2.Descricao);

            var curso = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso" };
            var curso1 = new Cadastro.CursoTeste();
            curso1.Id = curso.Id;
            curso1.Descricao = "Nova Descricao"; */

            var curso1 = new Cadastro.CursoRecord(1, "Curso");
            var curso2 = curso1 with { Descricao = "Nova Descricao" };
        }

        private static void AulaInterface()
        {
            var NotificacaoCliente = new Cadastro.NotificacaoCliente();
            NotificacaoCliente.Notificar();
            NotificacaoCliente.NotificarOutros();

            Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
            notificacao.Notificar();
            //notificacao.NotificarOutros(); Ao instanciar dessa maneira, o objeto só pega o que estiver na interface.
        }

        private static void Conversores()
        {
            var conversores = new Conversores.Conversores();
            //conversores.ConvertAndParse();
            conversores.AulaTryParse();
        }

        private static void TrabalhandoComStrings()
        {
            var trabalhandoComStrings = new FormatacaoString.TrabalhandoComStrings();
            trabalhandoComStrings.AulaRange();
        }

        private static void FormatacaoDatas()
        {
            var trabalhandoComDatas = new FormatacaoDatas.FormatandoDatas();
            trabalhandoComDatas.AulaTimeOnly();
        }

        private static void TrabalhandoComExcecoes()
        {
            var trabalhandoComExcecoes = new Excecao.TrabalhandoComExcecoes();
            trabalhandoComExcecoes.AulaTratandoException();
        }

        private static void TrabalhandoComArquivos()
        {
            var TrabalhandoComArquivos = new Arquivos.TrabalhandoComArquivos();
            TrabalhandoComArquivos.AulaExcluindoArquivos();
        }

        private static void TrabalhandoComLinq()
        {
            var linq = new LINQ.TrabalhandoComLinq();
            linq.AulaFirst();
        }
    }
}