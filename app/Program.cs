using System;

namespace advanced
{
  class Program
  {

    static void Main(string[] args)
    {


      Console.WriteLine("################################################");
      Console.WriteLine("################################################");
      Console.WriteLine("#########                              #########");
      Console.WriteLine("#########           Advanced           #########");
      Console.WriteLine("#########    Programa de Fidelidade    #########");
      Console.WriteLine("#########                              #########");
      Console.WriteLine("################################################");
      Console.WriteLine("################################################");
      Console.WriteLine();

      Console.WriteLine("Seja Bem-Vindo ao Advanced!");
      Console.WriteLine();

      Console.WriteLine("Digite o número da opção desejada:");
      Console.WriteLine("1 - Realizar Cadastro");
      Console.WriteLine("2 - Efetuar Login");
      Console.WriteLine();

      Premio premio = new Premio(1, "liquidificador", 30, "o mais brabo de todos");


      int opcao = Int32.Parse(Console.ReadLine());

      if (opcao == 1)
      {
        CadastroCliente.Menu();
      }
      else if (opcao == 2)
      {
        Login.Menu();
      }
      else
      {
        Console.WriteLine("Opção incorreta");
      }


    }
  }
}
