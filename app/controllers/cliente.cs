namespace advanced
{
  public class Cliente : Pessoa
  {

    public int pontuacao;
    public string historico;
    public string dados;
    public int id { get; }
    public string nome { get; }
    public string telefone { get; }
    public string documento { get; }
    public string email { get; }

    public Cliente(int pontuacao, string historico, string nome, string documento, string telefone, string email)
    {
      this.pontuacao = pontuacao;
      this.historico = historico;
      this.nome = nome;
      this.email = email;
      this.documento = documento;
      this.telefone = telefone;

      CadastrarCliente(this.nome, this.email, this.documento, this.telefone, this.pontuacao);
    }

    public string CadastrarCliente(string nome, string email, string documento, string telefone, int pontuacao)
    {
      return ClienteDAO.InserirCliente(nome, email, documento, telefone, pontuacao);
    }

    public string Imprimir()
    {
      dados = " Pontuação: " + pontuacao;
      return dados;
    }
  }
}
