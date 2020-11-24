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
<<<<<<< HEAD
    public Premio() { }
=======
    public Premio() {}
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
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

  }
}
