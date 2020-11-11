using System;
using System.Data;
using System.Data.SQLite;
namespace advanced
{
  public static class Database

  {
    private static SQLiteConnection sqliteConnection;

    private static SQLiteConnection DbConnection()
    {
      sqliteConnection = new SQLiteConnection("Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;");
      sqliteConnection.Open();
      return sqliteConnection;
    }


    public static string InserirPremio(int identificador, string nome, int pontuacao, string descricao)
    {
      try
      {
          using (var cmd = DbConnection().CreateCommand())
          {
              cmd.CommandText = "INSERT INTO premios(usuario_id, nome_premio, pontuacao, descricao) values (@usuario_id, @nome_premio, @pontuacao, @descricao)";
              cmd.Parameters.AddWithValue("@usuario_id", identificador);
              cmd.Parameters.AddWithValue("@nome_premio", nome);
              cmd.Parameters.AddWithValue("@pontuacao", pontuacao);
              cmd.Parameters.AddWithValue("@descricao", descricao);
              cmd.ExecuteNonQuery();
          }
          return "Inserido";
      }
      catch(Exception ex)
      {
          throw ex;
      }
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
      catch(Exception ex)
      {
          throw ex;
      }
    }
  }  
}