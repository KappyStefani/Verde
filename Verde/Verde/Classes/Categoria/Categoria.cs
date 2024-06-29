using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verde
{
    public class Categoria
    {
        ~Categoria() { 
        }
        #region Atributos Privados
        private int v_Cod_Categoria = -1;
        private string v_Nm_Categoria = "";
        #endregion
        #region Atributos Públicos
        public int Cod_Categoria
        {
            get => v_Cod_Categoria;
            set => v_Cod_Categoria = value;
        }
        public string Nm_Categoria
        {
            get => v_Nm_Categoria;
            set => v_Nm_Categoria= value;
        }
        #endregion
    }
}
