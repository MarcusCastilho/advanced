using System;
using System.Collections.Generic;

namespace advanced
{
    abstract class Promocao {
        protected int id;
        protected DateTime validade;
        protected List<string> tokens;

        public abstract bool Registrar();

        public abstract bool Resgatar();
    }
}
