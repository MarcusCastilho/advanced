using System.Data;
using System.Data.SQLite;

namespace advanced {
  public static class UsuarioDAO {

    public static bool Cadastrar(string nome, string telefone,  string documento, string email, string senha) {
      try {

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

        return true;

      } catch(DataException err) {
        return false;
      }

    }

  }
}
