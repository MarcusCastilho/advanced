namespace advanced
{
  public class Venda : Operacao {
    // ATRIBUTOS
    private float valor { get; set; }

    // CONSTRUTORES
    public Venda() {}
    public Venda(float valor) {
      this.valor = valor;
    }

    // MÉTODOS
    public override Operacao RegistrarOperacao()
    {
      return new Venda();
    }

  }
}
