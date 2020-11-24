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
        Console.WriteLine();
        Console.WriteLine("---------- Cadastro de Usuário ----------");
        Console.WriteLine();

        Console.Write("Digite seu nome ou de sua empresa (obrigatório): ");
        string nome = Console.ReadLine();
        Console.Write("Digite seu email (obrigatório): ");
        string email = Console.ReadLine();
        Console.Write("Digite seu CNPJ ou CPF (obrigatório): ");
        string cnpj = Console.ReadLine();
        Console.Write("Digite seu telefone: ");
        string tel = Console.ReadLine();
        Console.Write("Defina sua senha (obrigatório): ");
        string senha = Console.ReadLine();

        Usuario usuario = Usuario.CadastrarUsuario(nome, tel, cnpj, email, senha);
        Console.WriteLine("Cadastro Realizado!");



      }

    }

  }
}
