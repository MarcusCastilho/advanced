using System;

namespace advanced
{
<<<<<<< HEAD
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

=======
  public abstract class Operacao {
    // ATRIBUTOS
    protected int id;
    protected DateTime DataOperacao;
    
    // MÉTODOS 
    public abstract Operacao RegistrarOperacao(int cliente_id);
    
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
  }
}
