using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verde
{
    internal class Cliente
    {
        ~Cliente()
        {

        }

        #region Atributos Privados
        private int v_Cod_Cliente = -1;
        private string v_Nm_Cliente = "";
        private int v_Cel_Cliente = -1;
        private string v_CNPJ_Cliente = "";
        private string v_Mail_Cliente = "";

        #endregion

        #region Atributos Públicos 
        public int Cod_Cliente
        {
            get => v_Cod_Cliente;
            set => v_Cod_Cliente = value;
        }
        public string Nm_Cliente
        {
            get => v_Nm_Cliente;
            set => v_Nm_Cliente = value;
        }
        public int Cel_Cliente
        {
            get => v_Cel_Cliente;
            set => v_Cel_Cliente = value;
        }
        public string CNPJ_Cliente
        {
            get => v_CNPJ_Cliente;
            set => v_CNPJ_Cliente = value;
        }
        public string Mail_Cliente
        {
            get => v_Mail_Cliente;
            set => v_Mail_Cliente = value;
        }
        #endregion

    }
}
