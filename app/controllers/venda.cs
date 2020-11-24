using System;

namespace advanced
{
<<<<<<< HEAD
  public class Venda : Operacao
  {
=======
  public class Venda : Operacao {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
    // ATRIBUTOS
    private float valor { get; set; }

    // CONSTRUTORES
<<<<<<< HEAD
    public Venda(int id, DateTime DataOperacao, float valor) : base(id, DataOperacao)
    {
=======
    public Venda(int id, DateTime DataOperacao, float valor) : base(id, DataOperacao) {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
      this.id = id;
      this.DataOperacao = DataOperacao;
      this.valor = valor;
    }

    // MÉTODOS
<<<<<<< HEAD
    public override bool RegistrarOperacao(int cliente_id)
=======
    public override Operacao RegistrarOperacao(int cliente_id)
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
    {
      var resp = OperacaoDAO.InserirVenda(cliente_id, this.valor);

      return resp;
    }

  }
}
