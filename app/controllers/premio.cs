using System;
using System.Data;

namespace advanced
{
  public class Premio
  {
    // ATRIBUTOS
    public int identificador;
    public string nome;
    public int pontuacao;
    public string descricao;

    // CONSTRUTORES
    public Premio() { }
    public Premio(int identificador, string nome, int pontuacao, string descricao)
    {
      this.identificador = identificador;
      this.nome = nome;
      this.pontuacao = pontuacao;
      this.descricao = descricao;
    }

    // MÉTODOS
    public static bool CadastrarPremio(int usuario_id, string nome, int pontuacao, string descricao)
    {
      var resp = PremioDAO.InserirPremio(usuario_id, nome, pontuacao, descricao);

      return resp;
    }

    public static DataTable BuscarPremio(int usuario_id)
    {
      var resp = PremioDAO.BuscarPremio(usuario_id);

      return resp;
    }

  }
}
