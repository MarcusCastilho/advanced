<<<<<<< HEAD
namespace advanced
{

  public abstract class Pessoa
  {
    public string nome;
    public string telefone;
    public string documento;
    public string email;
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

=======
namespace advanced {
  interface Pessoa {
    int id { get; }
    string nome { get; }
    string telefone { get; }
    string documento { get; }
    string email { get; }

    bool Cadastro();
>>>>>>> 1c788c83b3ccccbf45f78c1b55818a1986e45eda
  }
}
