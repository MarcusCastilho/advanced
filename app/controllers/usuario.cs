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
<<<<<<< HEAD
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
=======
    public Usuario(int id, string nome, string telefone, string documento, string email)
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
    {
      this.id = id;
      this.nome = nome;
      this.telefone = telefone;
      this.documento = documento;
      this.email = email;

<<<<<<< HEAD
      this.clientes = clientes;
      this.premios = premios;
      this.promocoes = promocoes;

=======
      this.clientes = new List<Cliente>();
      this.premios = new List<Premio>();
      this.promocoes = new List<Promocao>();
    }
    public Usuario(int id, string nome, string telefone, string documento, string email, List<Cliente> clientes , List<Premio> premios, List<Promocao> promocoes)
    {
      this.id = id;
      this.nome = nome;
      this.telefone = telefone;
      this.documento = documento;
      this.email = email;

      this.clientes = clientes;
      this.premios = premios;
      this.promocoes = promocoes;
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
    }


    // MÉTODOS DE CLASSE
<<<<<<< HEAD
    public static Usuario CadastrarUsuario(string nome, string telefone, string documento, string email, string senha)
    {
      var resp = UsuarioDAO.Cadastrar(nome, telefone, documento, email, senha);

      if (resp)
      {
        return new Usuario(nome, telefone, documento, email, senha);
      }
      else
      {
=======
    public static Usuario CadastrarUsuario(string nome, string telefone, string documento, string email, string senha) {
      var resp = UsuarioDAO.Cadastrar(nome, telefone, documento, email, senha);

      if(resp) {
        return new Usuario(nome, telefone, documento, email, senha);
      } else {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
        return null;
      }

    }


    // MÉTODOS DE INSTÂNCIA
<<<<<<< HEAD
    public bool Vender(Cliente cliente, float valor)
    {
=======
    public bool Vender(Cliente cliente, float valor) {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
      var resp = cliente.Comprar(valor);
      // Retornar se deu certo ou errado a operação de venda
      return resp;
    }

<<<<<<< HEAD
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
=======
    public bool CadastrarCliente(string nome, string telefone, string documento, string email) {
      var resp = Cliente.CadastrarCliente(this.id, nome, telefone, documento, email);

      if(resp != null) {
        this.clientes.Add(resp);
        return true;
      } else {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
        return false;
      }
    }

<<<<<<< HEAD
    public bool CadastrarPremio(string nome, int pontuacao, string descricao)
    {
=======
    public bool CadastrarPremio(string nome, int pontuacao, string descricao) {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
      var resp = Premio.CadastrarPremio(this.id, nome, pontuacao, descricao);

      return resp;
    }

<<<<<<< HEAD
    public void CriarPromocao(DateTime validade, float desconto)
    {
      var resp = Promocao.Registrar(this.id, validade, desconto);
    }

    public bool ResgatarPremio(Cliente cliente, Premio premio)
    {
=======
    public void CriarPromocao(DateTime validade, float desconto) {
      var resp = Promocao.Registrar(this.id, validade, desconto);
    }

    public bool ResgatarPremio(Cliente cliente, Premio premio) {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
      var resp = cliente.Resgatar(premio);

      return resp;
    }

<<<<<<< HEAD
    public void ResgatarPromocao()
    {
=======
    public void ResgatarPromocao() {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d

    }

  }
}
