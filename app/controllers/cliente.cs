namespace advanced
{
  public class Cliente : Pessoa
  {

    public int pontuacao;
    public string historico;
    public string dados;

    public Cliente(int pontuacao, string historico, string nome, string documento, string telefone, string email) : base(nome, telefone, documento, email)
    {
      this.pontuacao = pontuacao;
      this.historico = historico;

      CadastrarCliente(this.nome, this.email, this.documento, this.telefone, this.pontuacao);
    }

    public string CadastrarCliente(string nome, string email, string documento, string telefone, int pontuacao)
    {
      return Database.InserirCliente(nome, email, documento, telefone, pontuacao);
    }

    public string Imprimir()
    {
      dados = this.ListarDados() + " Pontuação: " + pontuacao;
      return dados;
    }
  }
}
