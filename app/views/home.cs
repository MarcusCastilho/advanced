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
        Console.WriteLine("4 - Realizar Resgate");
        Console.WriteLine("5 - Visualizar Premios");
        Console.WriteLine("6 - Visualizar Promoções");
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
        else if (opcao == 4)
        {
          RealizarResgate.Menu(usuario);

        }
        else if (opcao == 5)
        {
          var premios = Usuario.BuscarPremio(usuario.id);
          for (int i = 0; i < premios.Rows.Count; i++)
          {
            Console.WriteLine("Produto: " + premios.Rows[i]["nome_premio"].ToString() + " | Pontuação Exigida: " + premios.Rows[i]["pontuacao"].ToString() + " | Descrição: " + premios.Rows[i]["descricao"].ToString());
            Console.WriteLine();
          }
        }
        else if (opcao == 6)
        {
          var resp = Usuario.BuscarPromocoes(usuario.id);

          Console.WriteLine(resp);
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
