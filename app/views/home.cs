using System;

namespace advanced
{
  // Interface usuário, menu principal
  public static class Home
  {


    public static void Menu(Usuario usuario)
    {
      Console.WriteLine();
      Console.WriteLine("---------- Home  ----------");
      Console.WriteLine();

      bool sentinela = true;
      while (sentinela)
      {
        Console.WriteLine();
        Console.WriteLine("Digite o número da opção desejada:");
        Console.WriteLine("1 - Realizar Cadastro de Cliente");
        Console.WriteLine("2 - Cadastrar Promoção");
        Console.WriteLine("3 - Realizar Venda");
        Console.WriteLine("0 - Sair");
        Console.WriteLine();


        int opcao = Int32.Parse(Console.ReadLine());

        if (opcao == 1)
        {
          CadastroCliente.Menu(usuario);
        }
        else if (opcao == 2)
        {
          CadastroPromocao.Menu(usuario);

        }
        else if (opcao == 3)
        {
          RealizarVenda.Menu(usuario);

        }
        else if (opcao == 0)
        {
          Console.WriteLine("Obrigado!");
          sentinela = false;
        }
        else
        {
          Console.WriteLine("Opção Inválida");
        }
      }

    }


  }
}
