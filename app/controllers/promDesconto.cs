using System;
using System.Collections.Generic;

namespace advanced
{
    class PromDesconto : Promocao {
        public PromDesconto (int id, DateTime validade, List<string> tokens) {
            this.id = id;
            this.validade = validade;
            this.tokens = tokens;
        }

        public override bool Registrar() {
            var res = PromocaoDAO.RegistrarPromocaoDesconto();
        }

        public override bool Resgatar() {

        }
    }
}
