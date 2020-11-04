namespace advanced
{
  class Cliente : Pessoa
  {

    int pontuacao;
    string historico;
    string dados;

    public Cliente(int pontuacao, string historico, string nome, string telefone, string documento, string email) : base(nome, telefone, documento, email)
    {
      this.pontuacao = pontuacao;
      this.historico = historico;
    }

    public string Imprimir()
    {
      dados = this.ListarDados() + " Pontuação: " + pontuacao;
      return dados;
    }
  }
}
