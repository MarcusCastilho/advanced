using System;
using System.Data;
using System.Data.SQLite;

namespace advanced
{
<<<<<<< HEAD
  public static class OperacaoDAO
=======
  public static class OperacaoDAO 
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
  {
    public static bool InserirVenda(int cliente_id, float valor)
    {
      string DB_STRING = "Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb";
      // string DB_STRING = "Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;";
<<<<<<< HEAD
      try
      {
=======
      try {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
        SQLiteConnection conn = new SQLiteConnection(DB_STRING);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "insert into vendas (cliente_id, valor) values (@cliente_id, @valor)";
        cmd.Parameters.AddWithValue("@cliente_id", cliente_id);
        cmd.Parameters.AddWithValue("@valor", valor);
        cmd.ExecuteNonQuery();

        return true;
<<<<<<< HEAD
      }
      catch (DataException err)
      {
=======
      } catch (DataException err) {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
        return false;
      }
    }

    public static bool RealizarResgate(int cliente_id, int pontos)
    {
      string DB_STRING = "Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb";
      // string DB_STRING = "Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;";
<<<<<<< HEAD
      try
      {
=======
      try {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
        SQLiteConnection conn = new SQLiteConnection(DB_STRING);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "insert into resgates (cliente_id, pontos) values (@cliente_id, @pontos)";
        cmd.Parameters.AddWithValue("@cliente_id", cliente_id);
        cmd.Parameters.AddWithValue("@pontos", pontos);
        cmd.ExecuteNonQuery();

        return true;
<<<<<<< HEAD
      }
      catch (DataException err)
      {
=======
      } catch (DataException err) {
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
        return false;
      }
    }

  }
}
