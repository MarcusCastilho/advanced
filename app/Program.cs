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

      Cadastro cosumidor = new Cadastro("001", "Marcus Castilho", 27992520759, 06392297600, "marcuscastilho@ucl.br");
      Console.WriteLine(cosumidor.Imprimir());

    }
  }
}
