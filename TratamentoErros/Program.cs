//Menu de Inicialização

String entrada = string.Empty;
Console.WriteLine("-------------------");
Console.WriteLine("Tratamento de erros");
Console.WriteLine("-------------------");

do {
    Console.WriteLine("");
    Console.WriteLine("Selecione uma das opções abaixo:");
    Console.WriteLine("1 - Tratamento de erro");
    Console.WriteLine("2 - Try { } Catch { }");
    Console.WriteLine("3 - Cach com Filtros");
    Console.WriteLine("4 - ");
    Console.WriteLine("5 - ");
    Console.WriteLine("0 - Sair");

    entrada = Console.ReadLine();

    switch(entrada)
    {
      case "1" :
            //int count = int.Parse("abc");
            bool aux = true;
            while(aux)
            {

                Console.WriteLine("Quantos ovos na cesta?");
                string? input = Console.ReadLine();
                if(int.TryParse( input, out int count) )   //tryParse: entrada(imput) e saída(count)
                {
                    Console.WriteLine($"Existem {count} ovos no cesto.");
                    aux = false;
                }
                else
                {
                    Console.WriteLine("Não é um número válido.");
                    aux = true;
                }

            }

      break;

      case "2" :

            Console.WriteLine("Antes da Validação");
            Console.WriteLine("Informe sua Idade");
            string input2 = Console.ReadLine();
            try
            {
                int age = int.Parse(input2);
                // Forçando um erro de índice fora dos limites de vetor
                int[] vetInteiros = {10,11,12,13};
                Console.WriteLine( vetInteiros[vetInteiros.Length - 1] );
            }
            catch(IndexOutOfRangeException ixorgex)
            {
                Console.WriteLine("Queridão, posição inexistente no vetor.");
            }
            catch( FormatException fex )
            {
                Console.WriteLine("Erro de formato inválido de dados.");
            }
            catch( Exception ex )
            {
                Console.WriteLine("Ocorreu um erro. Dados Inválidos.");
                Console.WriteLine($"{ex.GetType()} : {ex.Message}");
            }
            Console.WriteLine("Depois da Validação.");

      break;

      case "3" :

          Console.WriteLine("Informe um valor:");
          string quantia = Console.ReadLine();
          if( string.IsNullOrEmpty(quantia) )
              Console.WriteLine("Quantia Inválida.");
          else
          {
              try
              {
                  decimal amountValue = decimal.Parse(quantia);
                  Console.WriteLine($"Valor formatado: {amountValue:C}");
              }
              catch(FormatException) when (quantia.Contains("$"))
              {
                  Console.WriteLine("O valor deve ser informado com $");
              }
              catch(FormatException fex)
              {
                  Console.WriteLine("Informe apenas o dígitos.");
              }
          }
      break;

      case "4" :
      break;

      case "5" :
      break;

      case "0" :
      break;

      default:
          Console.WriteLine("ATENÇÃO: Opção Inválida!");
      break;

    }

}while( !entrada.Equals("0") &&
        !string.IsNullOrWhiteSpace(entrada) );
