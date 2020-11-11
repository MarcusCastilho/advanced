namespace advanced
{
  public class Premio
  {

    public int identificador = 0;
    public string nome = "";
    public int pontuacao = 0;
    public string descricao = "";
    public Premio(int identificador, string nome, int pontuacao, string descricao)
    {
      this.identificador = identificador;
      this.nome = nome;
      this.pontuacao = pontuacao;
      this.descricao = descricao;

      CadastrarPremio(this.identificador, this.nome, this.pontuacao, this.descricao);
    }

    public string CadastrarPremio(int identificador, string nome, int pontuacao, string descricao)
    {
      return Database.InserirPremio(identificador, nome, pontuacao, descricao);
    }

  }
}
