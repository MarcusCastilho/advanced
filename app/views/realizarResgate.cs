using System;
using System.Data;

namespace advanced
{
  // Interface usuário, cadastro
  public static class RealizarResgate
  {
    private static DataTable dados;
    private static DataTable premios;
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
      Console.WriteLine("---------- Realizar Resgate ----------");
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

        Console.Write("Digite o tipo de resgate (obrigatório) [1- Desconto / 2- Premio]: ");
        string tipo = Console.ReadLine();

        if (tipo == "1")
        {

        }
        else
        {
          premios = Usuario.BuscarPremio(usuario.id);
          for (int i = 0; i < premios.Rows.Count; i++)
          {
            Console.WriteLine("id: " + premios.Rows[i]["premio_id"].ToString() + " | Produto: " + premios.Rows[i]["nome_premio"].ToString() + " | Pontuação Exigida: " + premios.Rows[i]["pontuacao"].ToString() + " | Descrição: " + premios.Rows[i]["descricao"].ToString());
            Console.WriteLine();
          }

          Console.Write("Digite o ID do premio a ser resgatado: ");
          int id_premio = Convert.ToInt32(Console.ReadLine());

          bool resp = usuario.ResgatarPremio(cliente, id_premio);

          if(resp) {
            Console.WriteLine("Resgate realizado com sucesso!");
          } else {
            Console.WriteLine("Falha ao realizar resgatar!");
          }

          Home.Menu(usuario);

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
