//alterar valor das variaveis para testar as condições.
var diaDaSemana = 0;
var diaDeTrabalho = true;

if (diaDaSemana == 0 && !diaDeTrabalho) {
    Console.WriteLine("Domingo");
} else if (diaDaSemana == 1 && diaDeTrabalho) {
    Console.WriteLine("Hoje é segunda");
} else {
    Console.WriteLine("Hoje não é domingo nem segunda");
}

switch(diaDaSemana){
    case 0:
        Console.WriteLine("Hoje é domingo");
        break;
    case 1:
        Console.WriteLine("Hoje é segunda");
        break;
    case 2:
        Console.WriteLine("Hoje é terça");
        break;
    case 3:
        Console.WriteLine("Hoje é quarta");
        break;
    case 4:
        Console.WriteLine("Hoje é quinta");
        break;
    case 5:
        Console.WriteLine("Hoje é sexta");
        break;
}
var lista = new List<string>() {"Domingo", "Segunda", "Terça"};

for (var i=0; i < lista.Count; i++) {
    Console.WriteLine(lista[i]);
}

foreach (var item in lista) {
    Console.WriteLine(item);
}

var i = 0;
while (i < 2){
    Console.WriteLine(i);
    i++;
}

var j = 0;
do {
    Console.WriteLine("var j = " + j);
    j++;
} while (j < 2);
*/

var z = 0;
while (z < 5)
{
    Console.WriteLine("var z = " + z);
    if (z < 4)
    {
        Console.WriteLine("Exemplo de continue");
        z++;
        continue;
    }

    if (z == 4)
    {
        Console.WriteLine("O valor de Z é igual a 4");
        break;
    }
}