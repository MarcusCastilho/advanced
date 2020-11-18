using System;
using System.Collections.Generic;

namespace advanced
{
  class Usuario : Pessoa
  {

    public int id { get; }
    public string nome { get; }
    public string telefone { get; }
    public string documento { get; }
    public string email { get; }

    private List<Cliente> clientes;
    private List<Premio> premios;
    private List<Promocao> promocoes;

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

    public static bool CadastrarUsuario(string nome, string telefone, string documento, string email, string senha) {
      var res = UsuarioDAO.Cadastrar(nome, telefone, documento, email, senha);

      if(res) {
        return true;
      } else {
        return false;
      }

    }

    // MÉTODOS DE INSTÂNCIA
    // public bool CadastrarCliente(string nome, string telefone, string documento, string email) {
    //   var resp = Cliente.Cadastro(this.id, nome, telefone, documento, email);
    // }

  }
}
