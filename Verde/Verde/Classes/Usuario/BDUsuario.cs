using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verde
{
    internal class BDUsuario
    {
        ~BDUsuario()
        {

        }

        public int Incluir(Usuario pobj_Usuario)
        {

            MySqlConnection obj_Con = new MySqlConnection(Conn.strConn);

            string s_MySql_Comando = "INSERT INTO TB_USUARIO" +
                                   "( " +
                                   "I_COD_USUARIO, " +
                                   "S_NOME_USUARIO, " +
                                   "S_PASS_USUARIO, " +
                                   "S_MAIL_USUARIO " +
                                   "I_NIVEL_USUARIO" + 
                                   ") " +
                                   "VALUES " +
                                   "( " +
                                   "@I_COD_USUARIO, " +
                                   "@S_NOME_USUARIO, " +
                                   "@S_PASS_USUARIO, " +
                                   "@S_MAIL_USUARIO " +
                                   "@I_NIVEL_USUARIO" +
                                   "); " +
                                   " SELECT IDENT_CURRENT('TB_USUARIO') AS 'ID' ";

            MySqlCommand obj_Cmd = new MySqlCommand(s_MySql_Comando, obj_Con);

            obj_Cmd.Parameters.AddWithValue("@I_COD_USUARIO", pobj_Usuario.Cod_Usuario);
            obj_Cmd.Parameters.AddWithValue("@I_NOME_USUARIO", pobj_Usuario.Nome_Usuario);
            obj_Cmd.Parameters.AddWithValue("@S_PASS_USUARIO", pobj_Usuario.Pass_Usuario);
            obj_Cmd.Parameters.AddWithValue("@S_MAIL_USUARIO", pobj_Usuario.Mail_Usuario);
            obj_Cmd.Parameters.AddWithValue("@I_NIVEL_USUARIO", pobj_Usuario.Nivel_Usuario);

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
    }
}
