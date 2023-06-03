string entrada = string.Empty;

do 
  {
  Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
  Console.WriteLine("Bem-Vindo ao atendimento online, em que podemos ajudar?");
  Console.WriteLine("01 - Cadastramento");
  Console.WriteLine("02 - Relatórios");
  Console.WriteLine("03 - SAIR");

  entrada = Console.ReadLine();

switch(entrada)
{
  case "01":

    bool Cadastro = true;
    while (Cadastro)
      {
      string entradaCadastro = "";
        Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
        Console.WriteLine("Menu de cadastros, o que deseja realizar?");
        Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
        Console.WriteLine("01 - Cadastramento do Médico");
        Console.WriteLine("02 - Cadastramento do Animal");
        Console.WriteLine("03 - Atendimento");
        Console.WriteLine("04 - Sair");
        entradaCadastro = Console.ReadLine();
            switch(entradaCadastro)
              {
              case "01":
                bool cadastroMedico = true;
                  while(cadastroMedico)
                  {
                    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                    Console.WriteLine("Menu de Cadastramento Médico");
                    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                    Console.WriteLine("Nome Completo");
                  string nameMedico = Console.ReadLine();
                    Console.WriteLine("Número do RG");
                  string rgMedico = Console.ReadLine();
                    Console.WriteLine("Data de Nascimento");
                  string dayMedico = Console.ReadLine();

                    Console.WriteLine($"Médico {nameMedico}, Data de Nascimento {dayMedico}, RG {rgMedico}");
                    Console.WriteLine("Novo cadastro realizado!");
                    break;
                  }
                  break;

              case "02":

                bool cadastroAnimal = true;
                  while(cadastroAnimal)
                    {
                      Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                      Console.WriteLine("Menu de Cadastramento Animal");
                      Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                      Console.WriteLine("Nome");
                    string nameAnimal = Console.ReadLine();
                      Console.WriteLine("Raça do Animal");
                    string raceAnimal = Console.ReadLine();
                      Console.WriteLine("Data de Nascimento");
                    string birthAnimal = Console.ReadLine();

                      Console.WriteLine($" O(A) {nameAnimal}, da raça {raceAnimal}, nascida no dia {birthAnimal}");
                      Console.WriteLine("Cadastramento realizado!");
                  break;
                    } 
                  break;  

              case "03":
              bool atendimento = true;
                while(atendimento)
                {
                  Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                  Console.WriteLine("Você está no Menu de Atendimentos");
                  Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                  Console.WriteLine("Data do Atendimento");
                string dateAtendi = Console.ReadLine();
                  Console.WriteLine("Horário de Atendimento");
                string hourAtendi = Console.ReadLine();
                  Console.WriteLine("Responsável do Animal");
                string respAtendi = Console.ReadLine();
                  Console.WriteLine("Nome do Animal");
                string nameAtendi = Console.ReadLine();
                  Console.WriteLine("Raça do Animal");
                string raceAtendi = Console.ReadLine();
                  Console.WriteLine($" Agendado a consulta para o dia {dateAtendi}, ás  {hourAtendi}, com o responsável {respAtendi} do animal {nameAtendi} {raceAtendi}");
                  Console.WriteLine("Atendimento realizado!");
                  break;
                }
                  break;

              case "04":
                Cadastro = false;
              break;

              default:
                Console.WriteLine("OPS, OPÇÃO INVÁLIDA!");
              break;
              }
      }
          break;


  case "O2":
    bool relatorio = true;
      while(relatorio)
      {
        string entradaRelatorio = " ";
          Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
          Console.WriteLine("Menu de Relatórios");
          Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
          Console.WriteLine("01 - Relatório do Animal");
          Console.WriteLine("02 - Relatório do Atendimento");
          Console.WriteLine("03 - Sair");
        entradaRelatorio = Console.ReadLine();

  switch(entradaRelatorio)
  {

    case "01":
      bool relatorioAnimal = true;
        while(relatorioAnimal)
        {
          Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
          Console.WriteLine("Menu de Relatório do Animal");
          Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
          Console.WriteLine("Responsável pelo Animal");
        string respAnimal = Console.ReadLine();
          Console.WriteLine("Qual a raça do animal ?");
        string raceAnimal = Console.ReadLine();
          Console.WriteLine("Nome do Animal");
        string nameAnimal = Console.ReadLine();

          Console.WriteLine($"Informamos ao cliente {respAnimal} que o seu(sua) {raceAnimal} {nameAnimal} foi liberada da consulta!");
          Console.WriteLine("Agradecemos pela preferência e volte sempre!");
        break;
        }
        break;

  case "02":
    bool relatorioAtendimento = true;
      while(relatorioAtendimento)
        {
          Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
          Console.WriteLine("Você está no Menu de Relatório de Atendimento");
          Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
          Console.WriteLine("Informe o nome do do responsável pelo atendimento");
        string resSolicitante = Console.ReadLine();
          Console.WriteLine("Informe a raça do animal");
        string raceSolicitante = Console.ReadLine();
          Console.WriteLine("Informe o nome do animal");
        string nameSolicitante = Console.ReadLine();


        Console.WriteLine($"Atenção {resSolicitante} o(a) seu(sua) {raceSolicitante} {nameSolicitante} foi internado etá sendo medicado e tratamo com todo carinho e atenção!");
        Console.WriteLine("Agradecemos pela preferência e volte sempre!");
        break;
        }
        break;

  case "3":
    relatorio = false;  
        break;

  default:
    Console.WriteLine("OPS, OPÇÃO INVÁLIDA!!");
        break;
  }
      }
        break;

  case "00":
        break;

  default:
    Console.WriteLine("OPS, OPÇÃO INVÁLIDA!");
        break;
}
  }
while( !entrada.Equals("00") && 
!string.IsNullOrWhiteSpace(entrada) );