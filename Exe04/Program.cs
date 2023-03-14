var myFloat = 10f;
float meuFloat = 11;

//Conversão de tipo numérico

int myInteger = 100;
meuFloat = (float)myInteger;

decimal myDecimal = Convert.ToDecimal(myInteger);

//força o mydouble
var myDouble = 10d;
//chama mydouble
myDecimal = 10m;

string meuNumeroTexto = Convert.ToString(myInteger);
int qtdChars = meuNumeroTexto.Length;
for(int i = 0; i < qtdChars; i++)
{
    Console.WriteLine( meuNumeroTexto[i] );

}