using System;

namespace advanced
{
  // Interface usuário, cadastro
  public static class CadastroUsuario
  {
    public static void Menu()
    {
      while (true)
      {
        Console.WriteLine("##############################################");
        Console.WriteLine("##########    Cadastro de Usuário    #########");
        Console.WriteLine("##############################################\n\n");
        Console.Write("Digite seu nome  (obrigatório): ");
        string nome = Console.ReadLine();
        Console.Write("Digite seu email (obrigatório): ");
        string email = Console.ReadLine();
        Console.Write("Digite seu CNPJ ou CPF (obrigatório): ");
        string cnpj = Console.ReadLine();
        Console.Write("Digite seu telefone: ");
        string tel = Console.ReadLine();
        Console.Write("Defina sua senha (obrigatório): ");
        string senha = Console.ReadLine();

        Console.WriteLine(nome);
        Console.WriteLine(email);
        Console.WriteLine(cnpj);
        Console.WriteLine(tel);
        Console.WriteLine(senha);

        Usuario usuario = Usuario.CadastrarUsuario(nome, tel, cnpj, email, senha);

      }

    }

  }
}
