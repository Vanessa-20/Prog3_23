using Arquivos.Controller;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class ClinicaView
    {
        private ClinicaController clinicaControllers;

        public ClinicaView()
        {
            clinicaControllers = new ClinicaController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("***************");
            Console.WriteLine("Você está em Clínica");
            Console.WriteLine("***********");
            Console.WriteLine("");
            Console.WriteLine("01 - Inserir Clínica");
            Console.WriteLine("02 - Listar Clínica");
            Console.WriteLine("03 - Exportar para txt");
            Console.WriteLine("04 - Importar Clínica");
            Console.WriteLine("05 - Pesquisar Clínica");
            Console.WriteLine("00 - Sair");
            Console.WriteLine("");
            Console.WriteLine("***************");

            int option = 0;
            option = Convert.ToInt32(Console.ReadLine() );
            switch(option)
            {
                case 1 :
                    Insert();
                break;

                case 2 :
                    List();
                break;
                
                case 3:
                    Export();
                break;

                case 4:
                    Import();
                break;
                
                case 5:
                    SearchByName();
                    Console.WriteLine("Pesquisar");
                    Console.WriteLine("***************");
                    Console.WriteLine("1 - Pesquisar pelo nome.");
                    Console.WriteLine("2 - Pesquisar pelo endereço.");
                    int tipoPesquisa = Convert.ToInt32(Console.ReadLine() );
                    if(tipoPesquisa ==1)
                        SearchByName();
                    if(tipoPesquisa == 2)
                        SearchByAddress();
                    if(tipoPesquisa != 1 && tipoPesquisa !=2)
                        Console.WriteLine("\nDesculpe, opção inválida.\n");
                break;

                case 0:
                break;

                default:
                    Console.WriteLine("Desculpe, opção inválida!");
                    this.Init();
                break;
            }
        }

        private void List()
        {
            List<Clinica> listagem = 
                clinicaControllers.List();

            for (int i=0; i <listagem.Count; i++)
            {
                Console.WriteLine( Print( listagem[i] ) );
            }
        }
        private string Print(Clinica clinica)
        {
            string retorno = "";
            retorno+= $"Id: {clinica.Id} \n";
            retorno+= $"Nome: {clinica.Nome}\n";
            retorno +=$"Address: {clinica.Address}\n";
            retorno +=$"Telephone: {clinica.Telephone}\n";
            retorno+= "-------------------------------------------\n";
            return retorno;
        }

        private void Insert()
        {
            Clinica clinica = new Clinica();
            clinica.Id = clinicaControllers.GetNextId();
            
            Console.WriteLine("Informe o nome da Clínica:");
            clinica.Nome = Console.ReadLine();
            
            Console.WriteLine("Informe o localização:");
            clinica.Address = Console.ReadLine();

            Console.WriteLine("Informe seu contato");
            clinica.Telephone = Console.ReadLine();

            bool retorno = clinicaControllers.Insert(clinica);

            if (retorno)
                Console.WriteLine("Clínica inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");
        }
        private void Export()
        {
            if(clinicaControllers.ExportToTextFile())
                Console.WriteLine("Arquivo gerada com sucesso!");

            else
                Console.WriteLine("Ooops! Ocorreu uma falha na geração do Arquivo.");
            
        }

        private void Import()
        {
            if(clinicaControllers.ImportFromTxtFile())
                Console.WriteLine("Arquivo importado com sucesso!");
            else
                Console.WriteLine("Ooops! Ocorreu uma falha na importação do arquivo.");
        }

        private void SearchByName()
        {
            Console.WriteLine("Pesquisar Clínica Pela Nome.");
            Console.WriteLine("Digite o nome:");
            string name = Console.ReadLine();

            int contador = 0;

            foreach(Clinica c in 
                clinicaControllers.SearchByName(name) )
            {
                Console.WriteLine( c.ToString() );
                contador++;
            }

            if(contador == 0)
                Console.WriteLine("\nOpção não encontrada!!!\n"); 
        }
        
        private void SearchByAddress()
        {
            Console.WriteLine ("Digite o endereço.");
            string Address = Console.ReadLine();

            int contador = 0;
            foreach( Clinica c in clinicaControllers.SearchByAddress(Address))
            {
                Console.WriteLine(c.ToString());
                contador ++;
            }
            if(contador == 0)
                Console.WriteLine("\nEndereço não encontrado!\n");        
        }

    }
}
