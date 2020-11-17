using System;
using System.Collections.Generic;

namespace advanced {
  class Usuario : Pessoa {

    public int id { get; }
    public string nome { get; }
    public string telefone { get; }
    public string documento { get; }
    public string email { get; }

    private List<Cliente> _clientes;
    private List<Premio> _premios;
    private List<Promocao> _promocoes;

    public Usuario (int id, string nome, string telefone, string documento, string email) {
      this._id = id;
      this._nome = nome;
      this._telefone = telefone;
      this._documento = documento;
      this._email = email;

      this._clientes = new List<Cliente>();
      this._premios = new List<Premio>();
      this._promocoes = new List<Promocao>();
    }


    // MÉTODOS DE CLASSE
    public static bool Cadastro(string nome, string telefone, string documento, string email, string senha) {
      UsuarioDAO.Cadastrar(nome, telefone, documento, email, senha);
    }

    // MÉTODOS DE INSTÂNCIA
    public bool CadastrarCliente(string nome, string telefone, string documento, string email) {
      var resp = Cliente.Cadastro(this.id, nome, telefone, documento, email);
    }

  }
}
