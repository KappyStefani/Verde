using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verde
{ 
    public class Bd_Categoria
    {
        public int Incluir(Categoria pobj_Categoria)
        {
            MySqlConnection obj_Con = new MySqlConnection(Connection.strConn);

            string s_MySql_Comando = "INSERT INTO TB_CATEGORIA ( v_Nm_Categoria) VALUES (@v_Nm_Categoria); SELECT IDENT_CURRENT('TB_CATEGORIA') AS 'I_COD_CATEGORIA'";

            MySqlCommand Obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            Obj_Cmd.Parameters.AddWithValue("@v_Nm_Categoria", pobj_Categoria.Nm_Categoria);

            try
            {
                obj_Con.Open();
                int I_COD_CATEGORIA = Convert.ToInt16(Obj_Cmd.ExecuteScalar());
                obj_Con.Close();
                return I_COD_CATEGORIA;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "ERRO FATAL NA INCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

        }

        public Categoria FindByCodCategoria(Categoria pobj_Categoria)
        {
            MySqlConnection obj_Con = new MySqlConnection(Connection.strConn);

            string s_MySql_Comando = "SELECT * FROM TB_CATEGORIA " +
                                   "WHERE v_Cod_Categoria = @v_Cod_Categoria;";

            MySqlCommand obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            obj_Cmd.Parameters.AddWithValue("@v_Cod_Categoria", pobj_Categoria.Cod_Categoria);

            try
            {

                obj_Con.Open();

                MySqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();
                    pobj_Categoria.Nm_Categoria = obj_Dtr["v_Nm_Categoria"].ToString();
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return pobj_Categoria;
                }
                else
                {
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return null;
                }

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "ERRO FATAL NA BUSCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public List<Categoria> FindAllCategoria()
        {
            MySqlConnection obj_Con = new MySqlConnection(Connection.strConn);

            string s_MySql_Comando = "SELECT * FROM TB_CATEGORIA ";

            MySqlCommand obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            try
            {
                obj_Con.Open();

                MySqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                List<Categoria> Lista = new List<Categoria>();

                if (obj_Dtr.HasRows)
                {
                    while (obj_Dtr.Read())
                    {
                        Categoria obj_Categoria = new Categoria();
                        obj_Categoria.Nm_Categoria = obj_Dtr["v_Nm_Categoria"].ToString();
                        Lista.Add(obj_Categoria);
                    }
                    obj_Con.Close();
                    obj_Dtr.Close();

                    return Lista;

                }
                else
                {
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return null;
                }

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "ERRO FATAL NA BUSCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
} 
}
