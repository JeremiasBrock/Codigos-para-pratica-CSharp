using System.Collections;

//Estrutura de Dados
var arrayList = new ArrayList();
arrayList.Add(1); // 0
arrayList.Add("Domingo"); // 1
arrayList.Add(true); // 2

arrayList.RemoveAt(0);

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

var arrayTipado = new int [3] {1, 2, 3};
arrayTipado[0] = 10;
arrayTipado[1] = 20;
arrayTipado[2] = 30;

Array.Resize(ref arrayTipado, 4);
arrayTipado[3] = 40;

foreach (var item in arrayTipado)
{
    Console.WriteLine(item);
}

var lista = new List<string>(7)
{ // Adicionar dados sem o lista.add
    "Domingo",
    "Segunda",
    "Terça",
    "Quarta",
    "Quinta"
};

lista.Add("Sexta");
lista.Add("Sábado");

foreach (var item in lista)
{
    Console.WriteLine(item);
}

var dicionario = new Dictionary<int, string>();
dicionario.Add(1, "Um");
dicionario.Add(2, "Dois");
dicionario.Add(3, "Três");
dicionario[50] = "Cinquenta";

foreach (var item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

var queue = new Queue<string>();
queue.Enqueue("Primeiro");
queue.Enqueue("Segundo");

var nome = queue.Peek();//Seleciona o ultimo item da queue sem remove-lo
var nome1 = queue.Dequeue();//Remove o primeiro item da queue

foreach (var varitem in queue)
{
    Console.WriteLine(varitem);
}

var stack = new Stack<string>();
stack.Push("Primeiro");
stack.Push("Segundo");
var nome2 = stack.Peek();//Seleciona o ultimo item da stack sem remove-lo
var nome3 = stack.Pop();//Remove o ultimo item da stack

foreach (var item in stack)
{
    Console.WriteLine(item);
}