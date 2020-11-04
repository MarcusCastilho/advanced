namespace advanced
{
  // Interface usuário, cadastro
  public class Cadastro
  {
    string nome;
    string telefone;
    string documento;
    string email;
    string dados;


    public Cadastro()
    {
    }

    public void Cadastrar(string nome, string telefone, string documento, string email)
    {
      this.nome = nome;
      this.telefone = telefone;
      this.documento = documento;
      this.email = email;
    }

    public bool VerificaCadastro(string cpf)
    {
      if (cpf == "06392297600")
      {
        return true;
      }
      return false;
    }

    public string Imprimir()
    {
      dados = "Nome: " + this.nome + " Email: " + this.email + " CPF: " + this.documento + " Telefone: " + this.telefone;
      return dados;
    }

  }
}
