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
    public Usuario() {}
    public Usuario(int id, string nome, string telefone, string documento, string email)
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


    // MÉTODOS DE CLASSE
    public static Usuario CadastrarUsuario(string nome, string telefone, string documento, string email, string senha) {
      var res = UsuarioDAO.Cadastrar(nome, telefone, documento, email, senha);

      if(res) {
        return new Usuario();
      } else {
        return null;
      }

    }


    // MÉTODOS DE INSTÂNCIA
    public void Vender(Cliente cliente, float valor) {
      cliente.Comprar(valor);
    }

    public void CadastrarCliente(string nome, string telefone, string documento, string email) {
      var resp = Cliente.CadastrarCliente(this.id, nome, telefone, documento, email);
      if(resp != null)
        this.clientes.Add(resp);
    }

    public void CadastrarPremio() {

    }

    public void CriarPromocao() {

    }

    public void ResgatarPremio() {

    }

    public void ResgatarPromocao() {

    }

  }
}
