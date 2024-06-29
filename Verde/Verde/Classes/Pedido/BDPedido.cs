using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verde
{
    internal class BDPedido
    {
        //destructor classe
        ~BDPedido()
        {

        }

        //Método Inlcuir
            public int Incluir(Pedido pobj_Pedido)
            {
 
                MySqlConnection obj_Con = new MySqlConnection(Conn.strConn);

                string s_MySql_Comando = "INSERT INTO TB_PEDIDO " +
                                       "( " +
                                       "I_COD_PEDIDO, " +
                                       "I_COD_CLIENTE, " +
                                       "DT_DATA_PEDIDO, " +
                                       "D_TOT_PEDIDO "+ 
                                       ") " +
                                       "VALUES " +
                                       "( " +
                                       "@I_COD_PEDIDO, " +
                                       "@I_COD_CLIENTE, " +
                                       "@DT_DATA_PEDIDO, " +
                                       "@D_TOT_PEDIDO " +
                                       "); " +
                                       " SELECT IDENT_CURRENT('TB_PEDIDO') AS 'ID' ";

                MySqlCommand obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

                obj_Cmd.Parameters.AddWithValue("@I_COD_PEDIDO", pobj_Pedido.Cod_Pedido);
                obj_Cmd.Parameters.AddWithValue("@I_COD_CLIENTE", pobj_Pedido.Cod_Cliente);
                obj_Cmd.Parameters.AddWithValue("@DT_DATA_PEDIDO", pobj_Pedido.Tot_Pedido);
                obj_Cmd.Parameters.AddWithValue("@D_TOT_PEDIDO", pobj_Pedido.Tot_Pedido);
         
                try
                {
                    //Abrir a Conexão
                    obj_Con.Open();
                    //Executar o comando de forma escalar
                    int ID = Convert.ToInt16(obj_Cmd.ExecuteScalar());
                    //Fechar a Conexão
                    obj_Con.Close();
                    return ID;

                }
                catch (Exception Erro)
                {
                    MessageBox.Show(Erro.Message, "ERRO FATAL NA INCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }

        //FIND BY COD PEDIDO
        public Pedido FindByCodPedido(Pedido pobj_Pedido)
        {
            MySqlConnection obj_Con = new MySqlConnection(Conn.strConn);

            string s_MySql_Comando = "SELECT * FROM TB_PEDIDO " +
                                   "WHERE I_COD_PEDIDO = @I_COD_PEDIDO;";


            MySqlCommand obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            obj_Cmd.Parameters.AddWithValue("@I_COD_PEDIDO", pobj_Pedido.Cod_Pedido);

            try
            {
                obj_Con.Open();

                MySqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();

                    pobj_Pedido.Cod_Pedido = Convert.ToInt16(obj_Dtr["I_COD_PEDIDO"]);
                    pobj_Pedido.Cod_Cliente = Convert.ToInt16(obj_Dtr["I_COD_CLIENTE"]);
                    pobj_Pedido.Data_Pedido = Convert.ToDateTime(obj_Dtr["DT_DATA_PEDIDO"]);
                    pobj_Pedido.Tot_Pedido = Convert.ToDouble(obj_Dtr["D_TOT_PEDIDO"]);
                    

                    obj_Con.Close();
                    obj_Dtr.Close();
                    return pobj_Pedido;
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

        //FINDALLPEDIDO
        public List<Pedido> FindAllPedido()
        {
            MySqlConnection obj_Con = new MySqlConnection(Conn.strConn);

            string s_MySql_Comando = "SELECT * FROM TB_PEDIDO ";

            MySqlCommand obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            try
            {
                obj_Con.Open();

                MySqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                List<Pedido> Lista = new List<Pedido>();

                if (obj_Dtr.HasRows)
                {
                    while (obj_Dtr.Read())
                    {
                        Pedido obj_Pedido = new Pedido();
                        obj_Pedido.Cod_Pedido = Convert.ToInt16(obj_Dtr["I_COD_PEDIDO"]);
                        obj_Pedido.Cod_Cliente = Convert.ToInt16(obj_Dtr["I_COD_CLIENTE"]);
                        obj_Pedido.Data_Pedido = Convert.ToDateTime(obj_Dtr["DT_DATA_PEDIDO"]);
                        obj_Pedido.Tot_Pedido = Convert.ToDouble(obj_Dtr["D_TOT_PEDIDO"]);
                        Lista.Add(obj_Pedido);
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
