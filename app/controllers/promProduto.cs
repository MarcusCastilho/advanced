using System;
using System.Collections.Generic;

namespace advanced
{
  class PromProduto : Promocao{
    // CONSTRUTORES
    public PromProduto() {}
    public PromProduto (int id, DateTime validade, List<string> tokens) {
      this.id = id;
      this.validade = validade;
      this.tokens = tokens;
    }

    // MÉTODOS
    public override Promocao Registrar() {
      // var res = PromocaoDAO.RegistrarPromocaoProduto();
      return new PromProduto();
    }

    public override Promocao Resgatar() {
      return new PromProduto();
    }

  }
}
