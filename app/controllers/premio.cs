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
    public Premio() {}
    public Premio(int identificador, string nome, int pontuacao, string descricao)
    {
      this.identificador = identificador;
      this.nome = nome;
      this.pontuacao = pontuacao;
      this.descricao = descricao;
    }

    // MÉTODOS
    public static Premio CadastrarPremio(int identificador, string nome, int pontuacao, string descricao)
    {
      // Database.InserirPremio(identificador, nome, pontuacao, descricao);
      return new Premio();
    }

  }
}
