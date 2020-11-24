using System;
using System.Data;

namespace advanced
{
  // Interface usuário, cadastro
  public static class RealizarVenda
  {
    private static DataTable dados;
    private static int id;
    private static string nome;
    private static string tel;
    private static string email;
    private static string documento;
    private static int pontuacao;
    private static float valor;


    public static void Menu(Usuario usuario)
    {
      Console.WriteLine();
      Console.WriteLine("---------- Realizar Venda ----------");
      Console.WriteLine();


      Console.WriteLine("Digite cpf do cliente:");
      documento = Console.ReadLine();


      dados = Cliente.BuscarCliente(documento);
      if (dados.Rows.Count > 0)
      {
        for (int i = 0; i < dados.Rows.Count; i++)
        {
          id = Convert.ToInt32(dados.Rows[i]["cliente_id"]);
          nome = dados.Rows[i]["nome"].ToString();
          tel = dados.Rows[i]["tel"].ToString();
          email = dados.Rows[i]["email"].ToString();
          pontuacao = Convert.ToInt32(dados.Rows[i]["pontuacao"]);
        }

        Cliente cliente = new Cliente(id, pontuacao, nome, documento, tel, email);

        Console.WriteLine("Qual o valor da compra do cliente {0}:", nome);
        valor = float.Parse(Console.ReadLine());

        bool venda = usuario.Vender(cliente, valor);
        if (venda)
        {
          Console.WriteLine("Venda efetuada!");

        }

      }
      else
      {

        Console.WriteLine("Notamos que este cliente não possui cadastro, vamos cadastrar..");
        Console.WriteLine();

        CadastroCliente.Menu(usuario);
      }

    }

  }
}
