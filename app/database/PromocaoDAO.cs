using System;
using System.Data;
using System.Data.SQLite;

namespace advanced
{
<<<<<<< HEAD
  static class PromocaoDAO
  {
    public static bool RegistrarPromocao(int usuario_id, DateTime validade, float desconto)
    {
      try
      {
        // string DB_STRING = "Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb";
        string DB_STRING = "Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;";
=======
  static class PromocaoDAO {
    public static bool RegistrarPromocao(int usuario_id, DateTime validade, float desconto) {
      try {
        string DB_STRING = "Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb";
        // string DB_STRING = "Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;";
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d

        SQLiteConnection conn = new SQLiteConnection(DB_STRING);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "insert into promocoes (usuario_id, validade, desconto) values (@usuario_id, @validade, @desconto)";
        cmd.Parameters.AddWithValue("@usuario_id", usuario_id);
        cmd.Parameters.AddWithValue("@validade", validade);
        cmd.Parameters.AddWithValue("@desconto", desconto);
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

    // public static bool ResgatarToken(string token) {

    // }
  }
}
