using System;
using System.Data;
using System.Data.SQLite;

namespace advanced
{
  public static class UsuarioDAO
  {

    public static bool Cadastrar(string nome, string telefone, string documento, string email, string senha)
    {
      try
      {

        SQLiteConnection conn = new SQLiteConnection("Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb");
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "insert into usuario (nome, tel, email, cpf_cnpj, senha) values (@nome, @tel, @email, @cpf_cnpj, @senha)";
        cmd.Parameters.AddWithValue("@nome", nome);
        cmd.Parameters.AddWithValue("@tel", telefone);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@cpf_cnpj", documento);
        cmd.Parameters.AddWithValue("@senha", senha);
        cmd.ExecuteNonQuery();

      }
      catch (Exception ex)
      {
        throw ex;
      }

    }

    private static SQLiteConnection sqliteConnection;

    private static SQLiteConnection DbConnection()
    {
      sqliteConnection = new SQLiteConnection("Data Source=d:\\Cursos\\UCL\\periodo_4\\PROGRAMACAO_AVANCADA\\advanced\\app\\database\\pas.sdb; Version=3;");
      sqliteConnection.Open();
      return sqliteConnection;
    }

    public static DataTable BuscarCliente(string documento)
    {
      SQLiteDataAdapter da = null;
      DataTable dt = new DataTable();

      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "SELECT * FROM cliente Where cpf=" + documento;
          da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
          da.Fill(dt);
          return dt;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
