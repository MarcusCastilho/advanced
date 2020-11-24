using System;
using System.Data;
using System.Collections.Generic;


namespace advanced
{
  // Interface usuário, login
  public static class Login
  {

    private static int id;
    private static string nome;
    private static string tel;
    private static string email;
    private static string documento;
    private static string senha;
    private static List<Cliente> clientes = new List<Cliente>();
    private static List<Premio> premios = new List<Premio>();
    private static List<Promocao> promocoes = new List<Promocao>();


    private static DataTable dados;

    public static void Menu()
    {
      Console.WriteLine();
      Console.WriteLine("---------- Login  ----------");
      Console.WriteLine();

      Console.WriteLine("Agora vamos pedir suas informações cadastrais.");
      Console.WriteLine();

      Console.WriteLine("Digite seu CNPJ/CPF:");
      documento = Console.ReadLine();

      Console.WriteLine("Digite sua senha:");
      senha = Console.ReadLine();


      dados = UsuarioDAO.BuscarUsuario(documento, senha);
      if (dados.Rows.Count > 0)
      {
        for (int i = 0; i < dados.Rows.Count; i++)
        {
          id = Convert.ToInt32(dados.Rows[i]["usuario_id"]);
          nome = dados.Rows[i]["nome"].ToString();
          tel = dados.Rows[i]["tel"].ToString();
          email = dados.Rows[i]["email"].ToString();
          documento = dados.Rows[i]["cpf_cnpj"].ToString();
        }

        Usuario usuario = new Usuario(id, nome, tel, documento, email, clientes, premios, promocoes);
        Home.Menu(usuario);

      }
      else
      {

        Console.WriteLine("Notamos que não possui cadastro, vamos te cadastrar..");
        Console.WriteLine();

        Console.WriteLine("Digite o nome da sua Empresa ou seu Nome:");
        nome = Console.ReadLine();

        Console.WriteLine("Digite seu telefone:");
        tel = Console.ReadLine();

        Console.WriteLine("Digite seu email:");
        email = Console.ReadLine();

        Usuario usuario = Usuario.CadastrarUsuario(nome, tel, documento, email, senha);
        Home.Menu(usuario);
      }

    }
  }
}
