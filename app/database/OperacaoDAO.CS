using System;
using System.Data;
using System.Data.SQLite;

namespace advanced
{
  public static class OperacaoDAO 
  {
    public static bool InserirVenda(int cliente_id, float valor)
    {
      try {
        SQLiteConnection conn = new SQLiteConnection("Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb");
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "insert into vendas (cliente_id, valor) values (@cliente_id, @valor)";
        cmd.Parameters.AddWithValue("@cliente_id", cliente_id);
        cmd.Parameters.AddWithValue("@valor", valor);
        cmd.ExecuteNonQuery();

        return true;
      } catch (DataException err) {
        return false;
      }
    }

    public static bool RealizarResgate()
    {

    }

  }
}
