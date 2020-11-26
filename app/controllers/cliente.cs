using System;
using System.Collections.Generic;
using System.Data;


namespace advanced
{
  public class Cliente : Pessoa
  {
    // ATRIBUTOS 
    private int pontuacao;
    private List<Operacao> historico;
    private string dados;
    public int id { get; }
    public string nome { get; }
    public string telefone { get; }
    public string documento { get; }
    public string email { get; }
    public static DateTime Now = DateTime.Now;

    // CONSTRUTOR
    public Cliente() { }
    public Cliente(int usuario_id, int pontuacao, string nome, string documento, string telefone, string email)
    {
      this.id = usuario_id;
      this.pontuacao = pontuacao;
      this.nome = nome;
      this.email = email;
      this.documento = documento;
      this.telefone = telefone;

    }

    // MÉTODOS PÚBLICOS
    public static Cliente CadastrarCliente(int usuario_id, string nome, string email, string documento, string telefone, int pontuacao)
    {
      // remover 'pontuacao' e adicionar 'usuario_id' no DAO
      bool resp = ClienteDAO.InserirCliente(usuario_id, nome, email, documento, telefone, pontuacao);
      return new Cliente();
    }

    public static DataTable BuscarCliente(string documento)
    {
      var resp = ClienteDAO.BuscarCliente(documento);
      return resp;
    }

    public bool Comprar(float valor)
    {
      Console.WriteLine(this.id.ToString(), Now.ToString(), valor.ToString());
      var op = new Venda(this.id, Now, valor);
      var resp = op.RegistrarOperacao(this.id); // Vai inserir operação no banco

      if (resp)
      {
        this.pontuacao += (int)valor; // Adicionando valor da compra na pontuação 
        this.AtualizarPontuacao();

        return true;
      }
      else
      {
        return false;
      }

    }

    public bool Resgatar(Premio premio)
    {
      Console.WriteLine(this.id.ToString(), Now.ToString(), premio.pontuacao.ToString());
      var op = new Resgate(this.id, Now, premio);
      var resp = op.RegistrarOperacao(this.id); // Vai inserir operação no banco

      if (resp)
      {
        this.pontuacao -= (int)premio.pontuacao;
        this.AtualizarPontuacao();

        return true;
      }
      else
      {
        return false;
      }
    }

    // MÉTODOS PRIVADOS
    private bool AtualizarPontuacao()
    {
      var resp = ClienteDAO.AtualizarPontucao(this.id, this.pontuacao);

      return resp;
    }

  }
}
