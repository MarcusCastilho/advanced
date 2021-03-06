using System;
using System.Collections.Generic;

namespace advanced
{
  public class Promocao
  {
    // ATRIBUTOS
    private int id;
    private DateTime validade;
    private List<string> tokens;
    private float desconto;

    // CONSTRUTORES
    public Promocao() { }
    public Promocao(int id, DateTime validade, List<string> tokens, float desconto)
    {
      this.id = id;
      this.validade = validade;
      this.tokens = tokens;
      this.desconto = desconto;
    }

    // MÉTODOS
    public static bool Registrar(int usuario_id, DateTime validade, float desconto)
    {
      var resp = PromocaoDAO.RegistrarPromocao(usuario_id, validade, desconto);

      return resp;
    }

    public static string BuscarPromocoes(int usuario_id)
    {
      var promocoes = PromocaoDAO.BuscarPromocoes(usuario_id);
      var resp = "";

      for (int i = 0; i < promocoes.Rows.Count; i++)
      {
        resp += "Desconto Percentual: " + promocoes.Rows[i]["desconto"].ToString() + "% | Validade: " + promocoes.Rows[i]["validade"].ToString() + "\n\n";
      }

      return resp;
    }

  }
}
