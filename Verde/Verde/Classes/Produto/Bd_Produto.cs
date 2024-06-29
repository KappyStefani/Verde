using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verde
{
    public class Bd_Produto
    {
        public int Incluir(Produto pobj_Produto)
        {
            MySqlConnection obj_Con = new MySqlConnection(Connection.strConn);

            string s_MySql_Comando = "INSERT INTO TB_CATEGORIA (v_Nm_Produto, v_Vlr_Produto, v_Cod_Categoria) VALUES (@v_Nm_Produto, @v_Vlr_Produto, @v_Cod_Categoria); SELECT IDENT_CURRENT('TB_PRODUTO') AS 'I_COD_PRODUTO'";

            MySqlCommand Obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            Obj_Cmd.Parameters.AddWithValue("@v_Cod_Produto", pobj_Produto.Vlr_Produto);
            Obj_Cmd.Parameters.AddWithValue("@v_Nm_Produto", pobj_Produto.Nm_Produto);
            Obj_Cmd.Parameters.AddWithValue("@v_Cod_Categoria", pobj_Produto.Cod_Categoria);

            try
            {
                obj_Con.Open();
                int I_COD_PRODUTO = Convert.ToInt16(Obj_Cmd.ExecuteScalar());
                obj_Con.Close();
                return I_COD_PRODUTO;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "ERRO FATAL NA INCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

        }

        public Produto FindByCodProduto(Produto pobj_Produto)
        {
            MySqlConnection obj_Con = new MySqlConnection(Connection.strConn);

            string s_MySql_Comando = "SELECT * FROM TB_PRODUTO " +
                                   "WHERE v_Cod_Produto = @v_Cod_Produto;";

            MySqlCommand obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            obj_Cmd.Parameters.AddWithValue("@v_Cod_Produto", pobj_Produto.Cod_Produto);

            try
            {
 
                obj_Con.Open();

                MySqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();
                    pobj_Produto.Cod_Categoria = Convert.ToInt16(obj_Dtr["v_Cod_Categoria"]);
                    pobj_Produto.Nm_Produto = obj_Dtr["v_Nm_Produto"].ToString();
                    pobj_Produto.Vlr_Produto = Convert.ToInt16(obj_Dtr["v_Vlr_Produto"]);
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return pobj_Produto;
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
        public List<Produto> FindAllProduto()
        {
            MySqlConnection obj_Con = new MySqlConnection(Connection.strConn);

            string s_MySql_Comando = "SELECT * FROM TB_Produto ";

            MySqlCommand obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            try
            {
                obj_Con.Open();

                MySqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                List<Produto> Lista = new List<Produto>();

                if (obj_Dtr.HasRows)
                {
                    while (obj_Dtr.Read())
                    {
                        Produto obj_Produto = new Produto();
                        obj_Produto.Cod_Categoria = Convert.ToInt16(obj_Dtr["v_Cod_Categoria"]);
                        obj_Produto.Nm_Produto = obj_Dtr["v_Nm_Produto"].ToString();
                        obj_Produto.Vlr_Produto = Convert.ToInt16(obj_Dtr["v_Vlr_Produto"]);
                        Lista.Add(obj_Produto);
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

