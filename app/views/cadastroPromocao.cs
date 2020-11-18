using System;

namespace advanced {
  // Interface usuário, cadastro
    public static class CadastroPromocao {
        public static void Menu() {
            Console.WriteLine("###############################################");
            Console.WriteLine("##########    Cadastro de Promocao    #########");
            Console.WriteLine("###############################################\n\n");
            Console.Write("Digite o tipo de promoção (obrigatório) [1- Desconto / 2- Produto]: ");
            string tipo = Console.ReadLine();
            Console.Write("Digite a validade da promoção (obrigatório) [dd/mm/aaaa]: ");
            string validade = Console.ReadLine();
            if(tipo == "1") {
              Console.Write("Digite o percentual de desconto da promoção (obrigatório) [x%]: ");
              float desconto = float.Parse(Console.ReadLine());

              var res = PromDesconto.;
            } else {
              Console.Write("Digite o percentual de desconto da promoção (obrigatório) [x%]: ");
              string desconto = Console.ReadLine();
            }



      }
  }
}
