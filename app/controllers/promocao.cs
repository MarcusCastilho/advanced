using System;
using System.Collections.Generic;

namespace advanced
{
<<<<<<< HEAD
  public class Promocao
  {
=======
  public class Promocao {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
    // ATRIBUTOS
    private int id;
    private DateTime validade;
    private List<string> tokens;
    private float desconto;

    // CONSTRUTORES
<<<<<<< HEAD
    public Promocao() { }
    public Promocao(int id, DateTime validade, List<string> tokens, float desconto)
    {
=======
    public Promocao() {}
    public Promocao (int id, DateTime validade, List<string> tokens, float desconto) {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
      this.id = id;
      this.validade = validade;
      this.tokens = tokens;
      this.desconto = desconto;
    }

    // MÉTODOS
<<<<<<< HEAD
    public static bool Registrar(int usuario_id, DateTime validade, float desconto)
    {
=======
    public Promocao Registrar(int usuario_id, DateTime validade, float desconto) {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
      var resp = PromocaoDAO.RegistrarPromocao(usuario_id, validade, desconto);

      return resp;
    }
<<<<<<< HEAD

=======
    public Promocao Resgatar() {

    }
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d

  }
}
