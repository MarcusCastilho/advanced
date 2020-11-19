namespace advanced
{
  public class Resgate : Operacao {
    //  ATRIBUTOS
    private Premio premio;

    // CONSTRUTORES
    public Resgate() {}
    public Resgate(Premio premio) {
      this.premio = premio;
    }

    // MÉTODOS
    public override Operacao RegistrarOperacao()
    {
      return new Resgate();
    }
  }
}
