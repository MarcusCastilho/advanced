using System;

namespace advanced
{
  // Interface usuário, cadastro
  public static class CadastroCliente
  {

    private static string identificador = "";
    private static string nome = "";
    private static string telefone = "";
    private static string documento = "";
    private static string email = "";
    private static int pontuacao = 0;
    private static string historico = "";

    public static void Menu(Usuario usuario)
    {
      Console.WriteLine();
      Console.WriteLine("---------- Cadastro de Cliente ----------");
      Console.WriteLine();

      Console.WriteLine("Agora vamos pedir suas informações cadastrais.");
      Console.WriteLine();

      Console.WriteLine("Digite seu nome:");
      nome = Console.ReadLine();

      Console.WriteLine("Digite seu cpf:");
      documento = Console.ReadLine();

      Console.WriteLine("Digite seu telefone:");
      telefone = Console.ReadLine();

      Console.WriteLine("Digite seu email:");
      email = Console.ReadLine();

      bool cadastrado = usuario.CadastrarCliente(nome, telefone, documento, email);
      if (cadastrado)
      {
        Console.WriteLine("Cliente Cadastrado!");

      }
    }

  }
}
