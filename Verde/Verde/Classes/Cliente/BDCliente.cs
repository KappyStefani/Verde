using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verde
{
    internal class BDCliente
    {
        ~BDCliente()
        {

        }

        public int Incluir(Cliente pobj_Cliente)
        {

            MySqlConnection obj_Con = new MySqlConnection(Conn.strConn);

            string s_MySql_Comando = "INSERT INTO TB_CLIENTE" +
                                   "( " +
                                   "I_COD_CLIENTE, " +
                                   "S_NM_CLIENTE, " +
                                   "S_CNPJ_CLIENTE, " +
                                   "S_MAIL_CLIENTE " +
                                   "I_CEL_CLIENTE" +
                                   ") " +
                                   "VALUES " +
                                   "( " +
                                   "@I_COD_CLIENTE, " +
                                   "@S_NM_CLIENTE, " +
                                   "@S_CNPJ_CLIENTE, " +
                                   "@S_MAIL_CLIENTE " +
                                   "@I_CEL_CLIENTE" +
                                   "); " +
                                   " SELECT IDENT_CURRENT('TB_CLIENTE') AS 'ID' ";

            MySqlCommand obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            obj_Cmd.Parameters.AddWithValue("@I_COD_CLIENTE", pobj_Cliente.Cod_Cliente);
            obj_Cmd.Parameters.AddWithValue("@I_NM_CLIENTE", pobj_Cliente.Nm_Cliente);
            obj_Cmd.Parameters.AddWithValue("@S_CNPJ_CLIENTE", pobj_Cliente.CNPJ_Cliente);
            obj_Cmd.Parameters.AddWithValue("@S_MAIL_CLIENTE", pobj_Cliente.Mail_Cliente);
            obj_Cmd.Parameters.AddWithValue("@I_CEL_CLIENTE", pobj_Cliente.Cel_Cliente);

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
        //FIND BY COD CLIENTE
        public Cliente FindByCodCliente(Cliente pobj_Cliente)
        {
            MySqlConnection obj_Con = new MySqlConnection(Conn.strConn);

            string s_MySql_Comando = "SELECT * FROM TB_CLIENTE " +
                                   "WHERE I_COD_CLIENTE = @I_COD_CLIENTE;";


            MySqlCommand obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            obj_Cmd.Parameters.AddWithValue("@I_COD_CLIENTE", pobj_Cliente.Cod_Cliente);

            try
            {
                obj_Con.Open();

                MySqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();

                    pobj_Cliente.Cod_Cliente = Convert.ToInt16(obj_Dtr["I_COD_CLIENTE"]);
                    pobj_Cliente.Nm_Cliente = Convert.ToString(obj_Dtr["S_NM_CLIENTE"]);
                    pobj_Cliente.CNPJ_Cliente = Convert.ToString(obj_Dtr["S_CNPJ_CLIENTE"]);
                    pobj_Cliente.Mail_Cliente = Convert.ToString(obj_Dtr["S_MAIL_CLIENTE"]);
                    pobj_Cliente.Cel_Cliente = Convert.ToInt32(obj_Dtr["I_CEL_CLIENTE"]);


                    obj_Con.Close();
                    obj_Dtr.Close();
                    return pobj_Cliente;
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

        //FINDALLCLIENTE
        public List<Cliente> FindAllCliente()
        {
            MySqlConnection obj_Con = new MySqlConnection(Conn.strConn);

            string s_MySql_Comando = "SELECT * FROM TB_CLIENTE ";

            MySqlCommand obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            try
            {
                obj_Con.Open();

                MySqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                List<Cliente> Lista = new List<Cliente>();

                if (obj_Dtr.HasRows)
                {
                    while (obj_Dtr.Read())
                    {
                        Cliente obj_Cliente = new Cliente();
                        obj_Cliente.Cod_Cliente = Convert.ToInt16(obj_Dtr["I_COD_CLIENTE"]);
                        obj_Cliente.Nm_Cliente = Convert.ToString(obj_Dtr["S_NM_CLIENTE"]);
                        obj_Cliente.CNPJ_Cliente = Convert.ToString(obj_Dtr["S_CNPJ_CLIENTE"]);
                        obj_Cliente.Mail_Cliente = Convert.ToString(obj_Dtr["S_MAIL_CLIENTE"]);
                        obj_Cliente.Cel_Cliente = Convert.ToInt32(obj_Dtr["I_CEL_CLIENTE"]);
                        Lista.Add(obj_Cliente);
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

    

