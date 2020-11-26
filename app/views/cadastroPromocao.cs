using System;

namespace advanced
{
  // Interface usuário, cadastro
  public static class CadastroPromocao
  {
    public static void Menu(Usuario usuario)
    {
      Console.WriteLine();
      Console.WriteLine("---------- Cadastro de Promoção ----------");
      Console.WriteLine();

      Console.Write("Digite o tipo de promoção (obrigatório) [1- Desconto / 2- Premio]: ");
      string tipo = Console.ReadLine();

      if (tipo == "1")
      {
        Console.Write("Digite a validade da promoção (obrigatório) [dd/mm/aaaa]: ");
        string validade = Console.ReadLine();
        var parsedDate = DateTime.Parse(validade);

        Console.Write("Digite o percentual de desconto da promoção (obrigatório) [x%]: ");
        float desconto = float.Parse(Console.ReadLine());

        bool promocao = usuario.CriarPromocao(parsedDate, desconto);
        if (promocao)
        {
          Console.WriteLine("Promoção Cadastrada!");

        }

      }
      else
      {
        Console.Write("Digite o nome do premio: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a pontuação mínima para resgate deste premio: ");
        int pontuacao = Convert.ToInt32(Console.ReadLine());


        Console.Write("Digite a descrição deste premio: ");
        string descricao = Console.ReadLine();

        bool premio = usuario.CadastrarPremio(nome, pontuacao, descricao);

        if (premio)
        {
          Console.WriteLine("Premio Cadastrado!");
        }
      }
    }

  }
}
