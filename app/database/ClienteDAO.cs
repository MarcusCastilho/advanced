using System;
using System.Data;
using System.Data.SQLite;

namespace advanced
{
  public static class ClienteDAO

  {
    private static SQLiteConnection sqliteConnection;

    private static SQLiteConnection DbConnection()
    {
      string DB_STRING = "Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb";
      // string DB_STRING = "Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;";

      sqliteConnection = new SQLiteConnection(DB_STRING);
      sqliteConnection.Open();
      return sqliteConnection;
    }

    public static bool InserirCliente(int usuario_id, string nome, string email, string documento, string telefone, int pontuacao)
    {
      try
      {

        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "INSERT INTO cliente(nome, cpf, email, tel, pontuacao ) values (@nome, @cpf, @email, @tel, @pontuacao)";
          cmd.Parameters.AddWithValue("@nome", nome);
          cmd.Parameters.AddWithValue("@email", email);
          cmd.Parameters.AddWithValue("@cpf", documento);
          cmd.Parameters.AddWithValue("@tel", telefone);
          cmd.Parameters.AddWithValue("@pontuacao", pontuacao);
          cmd.ExecuteNonQuery();

          cmd.CommandText = "INSERT INTO usuario_cliente SELECT (SELECT @usuario_id), (SELECT cliente_id FROM cliente WHERE cpf = @cpf )";
          cmd.Parameters.AddWithValue("@usuario_id", usuario_id);
          cmd.Parameters.AddWithValue("@cpf", documento);
          cmd.ExecuteNonQuery();
        }
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return false;
      }
    }
    public static DataTable BuscarCliente(string documento)
    {
      SQLiteDataAdapter da = null;
      DataTable dt = new DataTable();

      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          Console.WriteLine(documento);
          cmd.CommandText = "SELECT * FROM cliente Where cpf=" + documento;
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

    public static bool AtualizarPontucao(int cliente_id, int pontuacao)
    {
      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "update cliente set pontuacao = @pontuacao where cliente_id = @cliente_id";
          cmd.Parameters.AddWithValue("@cliente_id", cliente_id);
          cmd.Parameters.AddWithValue("@pontuacao", pontuacao);
          cmd.ExecuteNonQuery();
        }
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

  }
}
