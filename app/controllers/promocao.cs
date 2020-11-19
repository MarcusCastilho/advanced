using System;
using System.Collections.Generic;

namespace advanced
{
  public abstract class Promocao {
    // ATRIBUTOS
    protected int id;
    protected DateTime validade;
    protected List<string> tokens;

    // MÉTODOS
    public abstract Promocao Registrar();
    public abstract Promocao Resgatar();
  }
}
