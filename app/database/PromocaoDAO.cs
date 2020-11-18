using System;
using System.Data;
using System.Data.SQLite;

namespace advanced
{
    static class PromocaoDAO {
        public static bool RegistrarPromocaoProduto(DateTime validade, int usuario_id, string tipo, int prod_id) {
            try {
                SQLiteConnection conn = new SQLiteConnection("Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb");
                conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandText = "insert into promocoes (usuario_id, validade, tipo, prod_id) values (@usuario_id, @validade, @tipo, @prod_id)";
                cmd.Parameters.AddWithValue("@usuario_id", usuario_id);
                cmd.Parameters.AddWithValue("@validade", validade);
                cmd.Parameters.AddWithValue("@prod_id", prod_id);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.ExecuteNonQuery();

                return true;
            } catch (DataException err) {
                return false;
            }
        }

        public static bool RegistrarPromocaoDesconto(DateTime validade, int usuario_id, string tipo, float desconto) {
            try {
                SQLiteConnection conn = new SQLiteConnection("Data Source=D:\\c#\\advanced\\app\\database\\pas.sdb");
                conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandText = "insert into promocoes (usuario_id, validade, tipo, perc_desconto) values (@usuario_id, @validade, @tipo, @desconto)";
                cmd.Parameters.AddWithValue("@usuario_id", usuario_id);
                cmd.Parameters.AddWithValue("@validade", validade);
                cmd.Parameters.AddWithValue("@desconto", desconto);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.ExecuteNonQuery();

                return true;
            } catch (DataException err) {
                return false;
            }
        }

        // public static bool ResgatarToken(string token) {

        // }
    }
}
