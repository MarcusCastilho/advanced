using System;

namespace advanced
{
  class Program
  {

    static void Main(string[] args)
    {

      Console.WriteLine("##############################################");
      Console.WriteLine("###############    Advanced    ###############");
      Console.WriteLine("#########    Programa de Fidelidade    ########");
      Console.WriteLine("##############################################");
      Console.WriteLine();



      Cadastro consumidor = new Cadastro();
      Console.WriteLine("Digite seu CPF:");
      string cpf = Console.ReadLine();

      if (!consumidor.VerificaCadastro(cpf))
      {
        Console.WriteLine("Verificamos que o Sr(a) não está cadastrado, iremos efetuar seu cadastro..");

        Console.WriteLine("Digite seu Nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite seu Telefone:");
        string telefone = Console.ReadLine();

        Console.WriteLine("Digite seu Email:");
        string email = Console.ReadLine();

        consumidor.Cadastrar(nome, telefone, cpf, email);
        Console.WriteLine(consumidor.Imprimir());
      }
      else
      {
        //   buscar no banco os dados do cliente

        Cliente cliente = new Cliente(10, "vazio", "Luiza Angelo", "2799817010", cpf, "luizatamires@gmail.com");
        Console.WriteLine(cliente.Imprimir());
      }



    }
  }
}
