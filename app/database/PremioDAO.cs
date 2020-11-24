using System;
using System.Data;
using System.Data.SQLite;
<<<<<<< HEAD

namespace advanced

=======
namespace advanced
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
{
  public static class PremioDAO
  {
    private static SQLiteConnection sqliteConnection;

    private static SQLiteConnection DbConnection()
    {
<<<<<<< HEAD
      // string DB_STRING = "Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb";
      string DB_STRING = "Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;";
=======
      string DB_STRING = "Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb";
      // string DB_STRING = "Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;";
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d

      sqliteConnection = new SQLiteConnection(DB_STRING);
      sqliteConnection.Open();
      return sqliteConnection;
    }


<<<<<<< HEAD
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
        Console.Write("inserido");
        return true;
      }
      catch (Exception ex)
      {
        Console.Write("não inserido");
        return false;
=======
    public static string InserirPremio(int usuario_id, string nome, int pontuacao, string descricao)
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
      catch(Exception ex)
      {
          return false;
>>>>>>> 2410836cb7c6ed22c6660915a2576041200bf49d
      }
    }

  }
}
