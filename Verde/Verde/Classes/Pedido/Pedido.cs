using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verde
{
    internal class Pedido
    {
        ~Pedido()
        {

        }

        #region Atributos Privados
        private int v_Cod_Pedido= -1;
        private int v_Cod_Cliente = -1;
        private DateTime v_Data_Pedido = DateTime.Now;
        private double v_Tot_Pedido = -1;
        #endregion

        #region Atributos Públicos 
        public int Cod_Pedido
        {
            get => v_Cod_Pedido;
            set => v_Cod_Pedido = value;
        }
        public int Cod_Cliente
        {
            get => v_Cod_Cliente;
            set => v_Cod_Cliente = value;
        }
        public DateTime Data_Pedido
        {
            get => v_Data_Pedido;
            set => v_Data_Pedido = value;
        }
        public double Tot_Pedido
        {
            get => v_Tot_Pedido;
            set => v_Tot_Pedido = value;
        }
        #endregion

    }
}
