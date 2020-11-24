using System;
using System.Collections.Generic;

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
    public bool Vender(Cliente cliente, float valor)
    {
      var resp = cliente.Comprar(valor);
      // Retornar se deu certo ou errado a operação de venda
      return resp;
    }

    public bool CadastrarCliente(string nome, string telefone, string documento, string email)
    {
      var resp = Cliente.CadastrarCliente(this.id, nome, telefone, documento, email, 0);

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

    public void CriarPromocao(DateTime validade, float desconto)
    {
      var resp = Promocao.Registrar(this.id, validade, desconto);
    }

    public bool ResgatarPremio(Cliente cliente, Premio premio)
    {
      var resp = cliente.Resgatar(premio);

      return resp;
    }

    public void ResgatarPromocao()
    {

    }

  }
}
