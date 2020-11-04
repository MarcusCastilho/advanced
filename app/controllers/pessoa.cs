namespace advanced
{

  abstract class Pessoa
  {
    string nome;
    string telefone;
    string documento;
    string email;
    string dados;

    public Pessoa(string nome, string telefone, string documento, string email)
    {
      this.nome = nome;
      this.telefone = telefone;
      this.documento = documento;
      this.email = email;
    }

    public string ListarDados()
    {
      dados = "Nome: " + this.nome + " Email: " + this.email + " CPF: " + this.documento + " Telefone: " + this.telefone;
      return dados;
    }

  }
}
