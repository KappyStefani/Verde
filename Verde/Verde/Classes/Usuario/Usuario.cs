using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verde
{
    internal class Usuario
    {
        ~Usuario()
        {

        }

        #region Atributos Privados
        private int v_Cod_Usuario = -1;
        private int v_Nome_Usuario= -1;
        private string v_Pass_Usuario = "";
        private int v_Nivel_Usuario = -1;
        private string v_Mail_Usuario = "";
        
        #endregion

        #region Atributos Públicos 
        public int Cod_Usuario
        {
            get => v_Cod_Usuario;
            set => v_Cod_Usuario = value;
        }
        public int Nome_Usuario
        {
            get => v_Nome_Usuario;
            set => v_Nome_Usuario = value;
        }
        public string Pass_Usuario 
        {
            get => v_Pass_Usuario;
            set => v_Pass_Usuario = value;
        }
        public int Nivel_Usuario
        {
            get => v_Nivel_Usuario;
            set => v_Nivel_Usuario = value;
        }
        public string Mail_Usuario
        {
            get => v_Mail_Usuario;
            set => v_Mail_Usuario = value;
        }
        #endregion

    }
}
