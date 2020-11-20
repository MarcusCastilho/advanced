using System;

namespace advanced
{
  public abstract class Operacao {
    // ATRIBUTOS
    protected int id;
    protected DateTime DataOperacao;
    
    // MÉTODOS 
    public abstract Operacao RegistrarOperacao(int cliente_id);
    
  }
}
