using System;
using System.Collections.Generic;

namespace advanced
{
    class PromProduto : Promocao{
        public PromProduto (int id, DateTime validade, List<string> tokens) {
            this.id = id;
            this.validade = validade;
            this.tokens = tokens;
        }

        public override bool Registrar() {
            var res = PromocaoDAO.RegistrarPromocaoProduto();
        }

        public override bool Resgatar() {

        }
    }
}
