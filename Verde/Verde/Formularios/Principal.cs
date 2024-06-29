using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using CsvHelper;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Linq;

namespace Verde.Formularios
{
    public partial class Principal : Form
    {
        private List<Pedido> pedidosJson;
        private List<Pedido> pedidosXml;
        private List<Pedido> pedidosCsv;

        public Principal()
        {
            InitializeComponent();

            ltview_Categoria.View = View.Details;
            ltview_Categoria.GridLines = true;
            ltview_Categoria.FullRowSelect = true;

            ltview_Categoria.Columns.Add("I_COD_CATEGORIA", 50, HorizontalAlignment.Left);
            ltview_Categoria.Columns.Add("S_NM_CATEGORIA", 150, HorizontalAlignment.Left);

            ltview_Cliente.Columns.Add("I_COD_CLIENTE", 50, HorizontalAlignment.Left);
            ltview_Cliente.Columns.Add("S_NM_CLIENTE", 150, HorizontalAlignment.Left);
            ltview_Cliente.Columns.Add("S_MAIL_CLIENTE", 250, HorizontalAlignment.Left);
            ltview_Cliente.Columns.Add("S_CEL_CLIENTE", 350, HorizontalAlignment.Left);
            ltview_Cliente.Columns.Add("S_CNPJ_CLIENTE", 450, HorizontalAlignment.Left);

        }

        private void btn_OpenSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|XML files (*.XML)|*.XML|CSV files (*.CSV)|*.CSV|All files (*.*)|*.*",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string conteudo = File.ReadAllText(openFileDialog.FileName);
                    dynamic objetoJson = JsonConvert.DeserializeObject(conteudo);
                    ltview_Categoria.Items.Clear();
                    foreach (var item in objetoJson)
                    {
                        ListViewItem ListViewItem = new ListViewItem(item["I_COD_CATEGORIA"].ToString());
                        ListViewItem.SubItems.Add(item["S_NM_CATEGORIA"].ToString());

                        ltview_Categoria.Items.Add(ListViewItem);
                    }
                    MessageBox.Show("Conteudo do arquivo lido");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao ler o arquivo: {ex.Message}");
                }
              
                
            }
        }

        private void PreencherListView(ListView listView, List<Pedido> pedidos)
        {
            listView.Items.Clear();
            foreach (var pedido in pedidos)
            {
                var item = new ListViewItem(pedido.Cod_Pedido.ToString());
                item.SubItems.Add(pedido.Cod_Cliente.ToString());
                item.SubItems.Add(pedido.Data_Pedido.ToString());
                item.SubItems.Add(pedido.Tot_Pedido.ToString());
                listView.Items.Add(item);
            }
        }
    }
}