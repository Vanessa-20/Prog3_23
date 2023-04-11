
//Operadores Unários
using FluxoTiposExceptions.Classes;

int x = 5;
int incrementoPosfixado = x++; // 6
incrementoPosfixado++;
x++; x = x + 1;
int incrementoPrefixado = ++x;
Console.WriteLine( $"Posfixado: {incrementoPosfixado}" );
Console.WriteLine( $"Prefixado: {incrementoPrefixado}" );

//Como obter o tipo de uma variável
Type tipoDeInteiro = typeof(int); //
Type tipoDeX = x.GetType();

//Como obter o nome de uma variável
string nomeDaVariavel = nameof(x);
int quantosBytes = sizeof(int);

Console.WriteLine( "Nomde da var: " + nomeDaVariavel );

//Operadores de atribuiação
int p = 6;
p += 3; //equivalente a p = p + 3;
Console.WriteLine($"+={p}");
p -= 3; //equivalente a p = p - 3;
Console.WriteLine($"-={p}");
p *= 3; //equivalente a p = p * 3;
Console.WriteLine($"*={p}");
p /= 3; //equivalente a p = p / 3;
Console.WriteLine($"/={p}");

//Operadores lógicos

bool a = true;
bool b = false;
WriteLine($"AND | a  | b   ");
WriteLine($"a   |{a & a, -5} | {a & b, -5}");
WriteLine($"b   |{b & a, -5} | {b & b, -5}");
WriteLine();
WriteLine($"OR  | a  | b  ");
WriteLine($"a   |{a | a, -5} | {a | b, -5}");
WriteLine($"a   |{b | a, -5} | {b | b, -5}");
WriteLine();
WriteLine($"XOR | a  | b  ");
WriteLine($"a   |{a ^ a, -5} | {a ^ b, -5}");
WriteLine($"b   |{b ^ a, -5} | {b ^ b, -5}");

static bool FacaAlgo()
{
    WriteLine("Fazendo alguma coisa");
    return true;
}
WriteLine();
WriteLine($"a & FacaAlgo() = {a & FacaAlgo()}");
WriteLine($"b & FacaAlgo() = {b & FacaAlgo()}");

//-----------------------------------------------------

Animal[] animals = new Animal[]
{
    new Cat{ 
        Name = "Garfield"
        , Born = new(year:2022, month: 8, day: 23)
        , Legs = 4
        , IsDomectis = true
    },
    new Animal{
        Name = "Eu mesmo"
        ,Born = new(year:2002, month:3, day:29)
        ,Legs = 2
    },
    new Cat{
        Name = "Mini"
        ,Born = new(year:1994, month: 6, day:12)
        ,Legs = 4
        ,IsDomectis = true
    },
    new Spider{
        Name = "Peter Parker"
        ,Born = DateTime.Today
        ,IsPoisonous = true
        ,Legs = 8
    },
    new Spider{
        Name = "Eddie Brick"
        ,Born = DateTime.Today
        ,IsPoisonous = true
        ,Legs = 8
    },
}; 

/*vetor (caica com divisão)
0        1       2        3    tamanho -1 
gato1 |eumesmo| gato2 | aranha | aranha|
*/

//Laços de repetição
//3 tipos de variáveis para controle de repetição
//1: Flag - Bandeirinha, boleano que indica se para ou continua
//2: Counter - Contador, Conta quantas vezes a repetição ocorreu
//3: Acumulador - Permite acumular valores e cada interção

//Laço for
for(int i = 0; i < animals.Length; i++)
{
    string message = string.Empty;
    if( animals[i] != null)
    {
        message = $"Nome: {animals[i].Name} ";
        message += $"Data Nasc: {animals[i].Born.ToShortDateString()} ";
        message += $"Numero Pernas {animals[i].Legs} ";}
    
    Console.WriteLine(message);
}

//Laço de repetição para cada
Console.WriteLine("\n---FOOREACH---\n");
foreach(Animal animal in animals)
{
    string message = string.Empty;
    if( animal != null)
    {
        message += $"Name: {animal.Name}";
    }
    Console.WriteLine(message);
}
