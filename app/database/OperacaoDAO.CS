using System;
using System.Data;
using System.Data.SQLite;

namespace advanced
{
  public static class OperacaoDAO
  {
    public static bool InserirVenda(int cliente_id, DateTime DataOperacao, float valor)
    {
      // string DB_STRING = "Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb";
      string DB_STRING = "Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;";
      try
      {
        Console.WriteLine(cliente_id.ToString(), valor);
        SQLiteConnection conn = new SQLiteConnection(DB_STRING);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "insert into vendas (cliente_id, dat, valor) values (@cliente_id, @DataOperacao, @valor)";
        cmd.Parameters.AddWithValue("@cliente_id", cliente_id);
        cmd.Parameters.AddWithValue("@DataOperacao", DataOperacao);
        cmd.Parameters.AddWithValue("@valor", valor);
        cmd.ExecuteNonQuery();

        return true;
      }
      catch (DataException err)
      {
        return false;
      }
    }

    public static bool RealizarResgate(int cliente_id, int pontos)
    {
      string DB_STRING = "Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb";
      // string DB_STRING = "Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;";
      try
      {
        SQLiteConnection conn = new SQLiteConnection(DB_STRING);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "insert into resgates (cliente_id, pontos) values (@cliente_id, @pontos)";
        cmd.Parameters.AddWithValue("@cliente_id", cliente_id);
        cmd.Parameters.AddWithValue("@pontos", pontos);
        cmd.ExecuteNonQuery();

        return true;
      }
      catch (DataException err)
      {
        return false;
      }
    }

  }
}
