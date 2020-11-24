using System;

namespace advanced
{
  public abstract class Operacao
  {
    // ATRIBUTOS
    protected int id { get; set; }
    protected DateTime DataOperacao { get; set; }

    // MÉTODOS 

    public Operacao(int id, DateTime DataOperacao)
    {
      this.id = id;
      this.DataOperacao = DataOperacao;
    }
    public abstract bool RegistrarOperacao(int cliente_id);

  }
}
