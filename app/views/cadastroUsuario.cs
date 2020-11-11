using System;

namespace advanced {
  // Interface usuário, cadastro
  public static class CadastroUsuario {
    public static void Menu() {
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

    Console.Write(nome);
    Console.Write(email);
    Console.Write(cnpj);
    Console.Write(tel);
    Console.Write(senha);
    // (nome, email, cnpj, tel, senha)
    }

  }
}
