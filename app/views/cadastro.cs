namespace advanced
{
  // Interface usuário, cadastro
  public class Cadastro
  {
    string identificador = "";
    string nome = "";
    int telefone;
    int documento;
    string email = "";

    public Cadastro(string identificador, string nome, int telefone, int documento, string email)
    {
      this.identificador = identificador;
      this.nome = nome;
      this.telefone = telefone;
      this.documento = documento;
      this.email = email;

      Pessoa consumidor = new Pessoa("TESTE");
    }

    public string Imprimir()
    {
      return this.identificador;
    }
  }
}
