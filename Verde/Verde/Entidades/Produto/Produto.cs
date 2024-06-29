using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verde
{
    public class Produto
    {
        ~Produto() { }

        #region Atributos Privados
        private int v_Cod_Produto = -1;
        private int v_Cod_Categoria = -1;
        private string v_Nm_Produto = "";
        private double v_Vlr_Produto = -1;
        #endregion

        #region Atributos Públicos
        public int Cod_Produto
        {
            get => v_Cod_Produto;
            set => v_Cod_Produto = value;   
        }
        public int Cod_Categoria
        {
            get => v_Cod_Categoria;
            set => v_Cod_Categoria= value;
        }
        public string Nm_Produto
        {
            get => v_Nm_Produto; 
            set => v_Nm_Produto = value;   
        }
        public double Vlr_Produto
        {
            get => v_Vlr_Produto; 
            set => v_Vlr_Produto = value;
        }
        #endregion


    }
}
