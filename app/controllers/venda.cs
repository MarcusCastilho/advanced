namespace advanced
{
  public class Venda : Operacao {
    // ATRIBUTOS
    private float valor { get; set; }

    // CONSTRUTORES
    public Venda(int id, DateTime DataOperacao, float valor) : base(id, DataOperacao) {
      this.id = id;
      this.DataOperacao = DataOperacao;
      this.valor = valor;
    }

    // MÉTODOS
    public override Operacao RegistrarOperacao(int cliente_id)
    {
      var resp = OperacaoDAO.InserirVenda(cliente_id, this.valor);

      return resp;
    }

  }
}
