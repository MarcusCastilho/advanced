using System;
using System.Collections.Generic;

namespace advanced
{
  class PromDesconto : Promocao {
    // ATRIBUTOS
    private float desconto;

    // CONTRUTORES
    public PromDesconto() {}
    public PromDesconto (int id, DateTime validade, List<string> tokens, float desconto) {
      this.id = id;
      this.validade = validade;
      this.tokens = tokens;
      this.desconto = desconto;
    }

    public override Promocao Registrar() {
      // var res = PromocaoDAO.RegistrarPromocaoDesconto();
      return new PromDesconto();
    }

    public override Promocao Resgatar() {
      return new PromDesconto();
    }
  }
}
