using System;
using System.Data;
using System.Data.SQLite;

namespace advanced
{
  static class PromocaoDAO
  {
    public static bool RegistrarPromocao(int usuario_id, DateTime validade, float desconto)
    {
      try
      {
        string DB_STRING = "Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb";
        // string DB_STRING = "Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;";

        SQLiteConnection conn = new SQLiteConnection(DB_STRING);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "insert into promocoes (usuario_id, validade, desconto) values (@usuario_id, @validade, @desconto)";
        cmd.Parameters.AddWithValue("@usuario_id", usuario_id);
        cmd.Parameters.AddWithValue("@validade", validade);
        cmd.Parameters.AddWithValue("@desconto", desconto);
        cmd.ExecuteNonQuery();

        return true;
      }
      catch (DataException err)
      {
        return false;
      }
    }

    public static DataTable BuscarPromocoes(int id)
    {
      try
      {
        string DB_STRING = "Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb";
        // string DB_STRING = "Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;";

        SQLiteConnection conn = new SQLiteConnection(DB_STRING);
        conn.Open();

        var query = "SELECT desconto, strftime('%d/%m/%Y', validade) as 'validade' FROM promocoes WHERE encerrada <> 1 and usuario_id=" + id;
        SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
        DataTable dt = new DataTable();
        da.Fill(dt);

        return dt;
      }
      catch (DataException err)
      {
        return null;
      }
    }

  }
}
