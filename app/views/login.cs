using System;

namespace advanced
{
  // Interface usuário, login
  public static class Login
  {

    private static string documento;
    private static string senha;

    public static void Menu()
    {
      Console.WriteLine("---------- Login  ----------");
      Console.WriteLine();

      Console.WriteLine("Agora vamos pedir suas informações cadastrais.");
      Console.WriteLine();

      Console.WriteLine("Digite seu CNPJ/CPF:");
      documento = Console.ReadLine();

      Console.WriteLine("Digite sua senha:");
      senha = Console.ReadLine();

      UsuarioDAO.BuscarCliente(documento);

    }
  }
}
