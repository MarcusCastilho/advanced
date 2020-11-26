using System;

namespace advanced
{
  public class Resgate : Operacao
  {
    //  ATRIBUTOS
    private Premio premio { get; set; }

    // CONSTRUTORES
    public Resgate(int id, DateTime DataOperacao, Premio premio) : base(id, DataOperacao)
    {
      this.id = id;
      this.DataOperacao = DataOperacao;
      this.premio = premio;
    }

    // MÉTODOS
    public override bool RegistrarOperacao(int cliente_id)
    {
      var resp = OperacaoDAO.RealizarResgate(cliente_id, this.DataOperacao, this.premio.pontuacao);

      return resp;
    }

  }
}
