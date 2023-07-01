using Arquivos.Views;
using Arquivos.Utils;

Bootsstrapper.ChargeClients();

int option = 0;

do
{
    Console.WriteLine ("*******************************************");
    Console.WriteLine ("Programa para leitura e exportação de dados");
    Console.WriteLine ("*******************************************");
    Console.WriteLine("");
    Console.WriteLine("01 - Clientes");
    Console.WriteLine("02 - Animais");
    Console.WriteLine("03 - Veterinários");
    Console.WriteLine("04 - Clínicas");
    Console.WriteLine("00 - Sair");
    Console.WriteLine("");

    option = Convert.ToInt32 ( Console.ReadLine () );

    switch ( option)
    {
        case 1 :
            Console.WriteLine ("Opção Clientes");
            ClientView clientView = new ClientView();
        break;

        case 2 :
            Console.WriteLine ("Opção Animais");
            AnimalView animalView = new AnimalView();
        break;

        case 3 :
            Console.WriteLine ("Opção Veterinários");
            VetView vetView = new VetView();
        break;

        case 4 :
            Console.WriteLine ("Opção Clínica");
            ClinicaView clinicaView = new ClinicaView();
        break;

        case 5 :
        break;

        default:
            Console.WriteLine("Desculpe, opção inválida!");
        break;
    }
}
while ( option > 0);