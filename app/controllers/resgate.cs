using System;

namespace advanced
{
<<<<<<< HEAD
  public class Resgate : Operacao
  {
=======
  public class Resgate : Operacao {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
    //  ATRIBUTOS
    private Premio premio { get; set; }

    // CONSTRUTORES
<<<<<<< HEAD
    public Resgate(int id, DateTime DataOperacao, Premio premio) : base(id, DataOperacao)
    {
=======
    public Resgate() {}
    public Resgate(int id, DateTime DataOperacao, Premio premio) : base(id, DataOperacao) {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
      this.id = id;
      this.DataOperacao = DataOperacao;
      this.premio = premio;
    }

    // MÉTODOS
<<<<<<< HEAD
    public override bool RegistrarOperacao(int cliente_id)
    {
      var resp = OperacaoDAO.RealizarResgate(cliente_id, this.premio.pontuacao);

      return resp;
    }

=======
    public override Operacao RegistrarOperacao(int cliente_id)
    {
      var resp = OperacaoDAO.RealizarResgate(cliente_id, this.premio.pontuacao);
      
      return resp;
    }
    
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
  }
}
