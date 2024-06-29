using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verde
{
    public class Itens
    {
        ~Itens()
        {

        }

        #region Atributos Privados
        private int v_Cod_Itens = -1;
        private int v_Cod_Pedido = -1;
        private int v_Cod_Produto = -1;
        private int v_Qtde_Itens = -1;
        private double v_VlrUnit_Itens = -1;
        #endregion

        #region Atributos Públicos
        public int Cod_Itens {
            get => v_Cod_Itens;
            set => v_Cod_Itens = value;
        }
        public int Cod_Pedido { 
            get => v_Cod_Pedido; 
            set => v_Cod_Pedido = value; 
        }
        public int Cod_Produto { 
            get => v_Cod_Produto; 
            set => v_Cod_Produto = value; 
        }
        public int Qtde_Itens { 
            get => v_Qtde_Itens; 
            set => v_Qtde_Itens = value; 
        }
        public double VlrUnit_Itens { 
            get => v_VlrUnit_Itens; 
            set => v_VlrUnit_Itens = value; 
        }
        #endregion
    }
}
