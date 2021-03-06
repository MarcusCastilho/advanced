using System;
using System.Collections.Generic;
using System.Data;


namespace advanced
{
  public class Usuario : Pessoa
  {
    // ATRIBUTOS 
    public int id { get; }
    public string nome { get; }
    public string telefone { get; }
    public string documento { get; }
    public string email { get; }
    private List<Cliente> clientes;
    private List<Premio> premios;
    private List<Promocao> promocoes;

    // CONSTRUTOR
    public Usuario(string nome, string telefone, string documento, string email, string senha)
    {
      this.id = id;
      this.nome = nome;
      this.telefone = telefone;
      this.documento = documento;
      this.email = email;

      this.clientes = new List<Cliente>();
      this.premios = new List<Premio>();
      this.promocoes = new List<Promocao>();
    }
    public Usuario(int id, string nome, string telefone, string documento, string email, List<Cliente> clientes, List<Premio> premios, List<Promocao> promocoes)
    {
      this.id = id;
      this.nome = nome;
      this.telefone = telefone;
      this.documento = documento;
      this.email = email;

      this.clientes = clientes;
      this.premios = premios;
      this.promocoes = promocoes;

    }


    // MÉTODOS DE CLASSE
    public static Usuario CadastrarUsuario(string nome, string telefone, string documento, string email, string senha)
    {
      var resp = UsuarioDAO.Cadastrar(nome, telefone, documento, email, senha);

      if (resp)
      {
        return new Usuario(nome, telefone, documento, email, senha);
      }
      else
      {
        return null;
      }

    }


    // MÉTODOS DE INSTÂNCIA
    public static DataTable BuscarUsuario(string documento, string senha)
    {
      var resp = UsuarioDAO.BuscarUsuario(documento, senha);
      return resp;
    }

    public static string BuscarPromocoes(int id)
    {
      var resp = Promocao.BuscarPromocoes(id);
      return resp;
    }

    public static DataTable BuscarPremio(int id)
    {
      var resp = Premio.BuscarPremio(id);
      return resp;
    }

    public bool Vender(Cliente cliente, float valor)
    {
      var resp = cliente.Comprar(valor);
      return resp;
    }

    public bool CadastrarCliente(string nome, string telefone, string documento, string email)
    {
      Cliente resp = Cliente.CadastrarCliente(this.id, nome, telefone, documento, email, 0);

      if (resp != null)
      {
        this.clientes.Add(resp);
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool CadastrarPremio(string nome, int pontuacao, string descricao)
    {
      var resp = Premio.CadastrarPremio(this.id, nome, pontuacao, descricao);

      return resp;
    }

    public bool CriarPromocao(DateTime validade, float desconto)
    {
      var resp = Promocao.Registrar(this.id, validade, desconto);
      return resp;
    }

    public bool ResgatarPremio(Cliente cliente, int id_premio)
    {
      var premio = PremioDAO.BuscarPremioPorId(id_premio);

      var nome = "";
      var pontuacao = "";
      var descricao = "";
      for (int i = 0; i < premio.Rows.Count; i++)
      {
        nome = premio.Rows[i]["nome_premio"].ToString();
        pontuacao = premio.Rows[i]["pontuacao"].ToString();
        descricao = premio.Rows[i]["descricao"].ToString();
      }

      Premio p = new Premio(id_premio, nome, Convert.ToInt32(pontuacao), descricao);

      var resp = cliente.Resgatar(p);

      return resp;
    }

    public void ResgatarPromocao()
    {

    }

  }
}
