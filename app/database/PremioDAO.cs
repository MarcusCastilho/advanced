using System;
using System.Data;
using System.Data.SQLite;

namespace advanced

{
  public static class PremioDAO
  {
    private static SQLiteConnection sqliteConnection;

    private static SQLiteConnection DbConnection()
    {
      // string DB_STRING = "Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb";
      string DB_STRING = "Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;";

      sqliteConnection = new SQLiteConnection(DB_STRING);
      sqliteConnection.Open();
      return sqliteConnection;
    }


    public static Boolean InserirPremio(int usuario_id, string nome, int pontuacao, string descricao)

    {
      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "INSERT INTO premios (usuario_id, nome_premio, pontuacao, descricao) values (@usuario_id, @nome_premio, @pontuacao, @descricao)";
          cmd.Parameters.AddWithValue("@usuario_id", usuario_id);
          cmd.Parameters.AddWithValue("@nome_premio", nome);
          cmd.Parameters.AddWithValue("@pontuacao", pontuacao);
          cmd.Parameters.AddWithValue("@descricao", descricao);
          cmd.ExecuteNonQuery();
        }
        return true;
      }
      catch (Exception ex)
      {
        Console.Write("não inserido");
        return false;
      }
    }

    public static DataTable BuscarPremio(int id)
    {
      SQLiteDataAdapter da = null;
      DataTable dt = new DataTable();

      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "SELECT * FROM premios Where usuario_id=" + id;
          da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
          da.Fill(dt);

          return dt;
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }
  }
}
