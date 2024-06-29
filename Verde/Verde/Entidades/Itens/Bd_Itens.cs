using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verde
{
    public class Bd_Itens
    {
        public int Incluir(Itens pobj_Itens)
        {
            MySqlConnection obj_Con = new MySqlConnection(Connection.strConn);

            string s_MySql_Comando = "INSERT INTO TB_CATEGORIA (v_Cod_Pedido, v_Cod_Produto, v_Qtde_Itens, v_VlrUnit_Itens) VALUES (@v_Cod_Pedido, @v_Cod_ITENS, @v_Qtde_Itens, @v_VlrUnit_Itens); SELECT IDENT_CURRENT('TB_ITENS') AS 'I_COD_ITENS'";

            MySqlCommand Obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            Obj_Cmd.Parameters.AddWithValue("@v_Cod_Pedido", pobj_Itens.Cod_Pedido);
            Obj_Cmd.Parameters.AddWithValue("@v_Cod_Produto", pobj_Itens.Cod_Produto);
            Obj_Cmd.Parameters.AddWithValue("@v_Qtde_Itens", pobj_Itens.Qtde_Itens);
            Obj_Cmd.Parameters.AddWithValue("@v_VlrUnit_Itens", pobj_Itens.VlrUnit_Itens);

            try
            {
                obj_Con.Open();
                int I_COD_ITENS = Convert.ToInt16(Obj_Cmd.ExecuteScalar());
                obj_Con.Close();
                return I_COD_ITENS;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "ERRO FATAL NA INCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

        }

        public Itens FindByCodITENS(Itens pobj_ITENS)
        {
            MySqlConnection obj_Con = new MySqlConnection(Connection.strConn);

            string s_MySql_Comando = "SELECT * FROM TB_ITENS " +
                                   "WHERE v_Cod_Itens = @v_Cod_Itens;";

            MySqlCommand obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            obj_Cmd.Parameters.AddWithValue("@v_Cod_Itens", pobj_ITENS.Cod_Itens);

            try
            {

                obj_Con.Open();

                MySqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();
                    pobj_ITENS.Cod_Pedido = Convert.ToInt16(obj_Dtr["v_Cod_Pedido"]);
                    pobj_ITENS.Cod_Produto = Convert.ToInt16(obj_Dtr["v_Cod_Produto"]);
                    pobj_ITENS.Qtde_Itens = Convert.ToInt16(obj_Dtr["v_Qtde_Itens"]);
                    pobj_ITENS.VlrUnit_Itens = Convert.ToInt16(obj_Dtr["v_VlrUnit_Itens"]);
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return pobj_ITENS;
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
        public List<Itens> FindAllITENS()
        {
            MySqlConnection obj_Con = new MySqlConnection(Connection.strConn);

            string s_MySql_Comando = "SELECT * FROM TB_ITENS ";

            MySqlCommand obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            try
            {
                obj_Con.Open();

                MySqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                List<Itens> Lista = new List<Itens>();

                if (obj_Dtr.HasRows)
                {
                    while (obj_Dtr.Read())
                    {
                        Itens obj_ITENS = new Itens();
                        obj_ITENS.Cod_Pedido = Convert.ToInt16(obj_Dtr["v_Cod_Pedido"]);
                        obj_ITENS.Cod_Produto = Convert.ToInt16(obj_Dtr["v_Cod_Produto"]);
                        obj_ITENS.Qtde_Itens = Convert.ToInt16(obj_Dtr["v_Qtde_Itens"]);
                        obj_ITENS.VlrUnit_Itens = Convert.ToInt16(obj_Dtr["v_VlrUnit_Itens"]);
                        Lista.Add(obj_ITENS);
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

