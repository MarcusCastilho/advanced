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
      sqliteConnection = new SQLiteConnection("Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;");
      sqliteConnection.Open();
      return sqliteConnection;
    }

    public static string InserirCliente(string nome, string email, string documento, string telefone, int pontuacao)
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
        }
        return "Inserido";
      }
      catch (Exception ex)
      {
        throw ex;
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
