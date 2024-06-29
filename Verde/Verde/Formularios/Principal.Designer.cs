namespace Verde.Formularios
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabPage tab_Principal;
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rbtn_XML = new System.Windows.Forms.RadioButton();
            this.rbtn_JSON = new System.Windows.Forms.RadioButton();
            this.rbtn_CSV = new System.Windows.Forms.RadioButton();
            this.tab_tot = new System.Windows.Forms.TabControl();
            this.tab_Categoria = new System.Windows.Forms.TabPage();
            this.ltview_Categoria = new System.Windows.Forms.ListView();
            this.tab_Cliente = new System.Windows.Forms.TabPage();
            this.ltview_Cliente = new System.Windows.Forms.ListView();
            this.tab_Itens = new System.Windows.Forms.TabPage();
            this.ltview_Itens = new System.Windows.Forms.ListView();
            this.tab_Pedidos = new System.Windows.Forms.TabPage();
            this.ltview_Pedidos = new System.Windows.Forms.ListView();
            this.tab_Produto = new System.Windows.Forms.TabPage();
            this.ltview_Produto = new System.Windows.Forms.ListView();
            this.btn_OpenSource = new System.Windows.Forms.Button();
            this.btn_Cliente = new System.Windows.Forms.Button();
            tab_Principal = new System.Windows.Forms.TabPage();
            tab_Principal.SuspendLayout();
            this.tab_tot.SuspendLayout();
            this.tab_Categoria.SuspendLayout();
            this.tab_Cliente.SuspendLayout();
            this.tab_Itens.SuspendLayout();
            this.tab_Pedidos.SuspendLayout();
            this.tab_Produto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Principal
            // 
            tab_Principal.Controls.Add(this.label1);
            tab_Principal.Controls.Add(this.button2);
            tab_Principal.Controls.Add(this.rbtn_XML);
            tab_Principal.Controls.Add(this.rbtn_JSON);
            tab_Principal.Controls.Add(this.rbtn_CSV);
            tab_Principal.Location = new System.Drawing.Point(4, 25);
            tab_Principal.Name = "tab_Principal";
            tab_Principal.Padding = new System.Windows.Forms.Padding(3);
            tab_Principal.Size = new System.Drawing.Size(933, 446);
            tab_Principal.TabIndex = 0;
            tab_Principal.Text = "Principal";
            tab_Principal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 46);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rbtn_XML
            // 
            this.rbtn_XML.AutoSize = true;
            this.rbtn_XML.Location = new System.Drawing.Point(25, 87);
            this.rbtn_XML.Name = "rbtn_XML";
            this.rbtn_XML.Size = new System.Drawing.Size(54, 20);
            this.rbtn_XML.TabIndex = 2;
            this.rbtn_XML.TabStop = true;
            this.rbtn_XML.Text = "XML";
            this.rbtn_XML.UseVisualStyleBackColor = true;
            // 
            // rbtn_JSON
            // 
            this.rbtn_JSON.AutoSize = true;
            this.rbtn_JSON.Location = new System.Drawing.Point(25, 61);
            this.rbtn_JSON.Name = "rbtn_JSON";
            this.rbtn_JSON.Size = new System.Drawing.Size(64, 20);
            this.rbtn_JSON.TabIndex = 1;
            this.rbtn_JSON.TabStop = true;
            this.rbtn_JSON.Text = "JSON";
            this.rbtn_JSON.UseVisualStyleBackColor = true;
            // 
            // rbtn_CSV
            // 
            this.rbtn_CSV.AutoSize = true;
            this.rbtn_CSV.Location = new System.Drawing.Point(25, 35);
            this.rbtn_CSV.Name = "rbtn_CSV";
            this.rbtn_CSV.Size = new System.Drawing.Size(55, 20);
            this.rbtn_CSV.TabIndex = 0;
            this.rbtn_CSV.TabStop = true;
            this.rbtn_CSV.Text = "CSV";
            this.rbtn_CSV.UseVisualStyleBackColor = true;
            // 
            // tab_tot
            // 
            this.tab_tot.Controls.Add(tab_Principal);
            this.tab_tot.Controls.Add(this.tab_Categoria);
            this.tab_tot.Controls.Add(this.tab_Cliente);
            this.tab_tot.Controls.Add(this.tab_Itens);
            this.tab_tot.Controls.Add(this.tab_Pedidos);
            this.tab_tot.Controls.Add(this.tab_Produto);
            this.tab_tot.Location = new System.Drawing.Point(-1, 12);
            this.tab_tot.Name = "tab_tot";
            this.tab_tot.SelectedIndex = 0;
            this.tab_tot.Size = new System.Drawing.Size(941, 475);
            this.tab_tot.TabIndex = 0;
            // 
            // tab_Categoria
            // 
            this.tab_Categoria.Controls.Add(this.btn_OpenSource);
            this.tab_Categoria.Controls.Add(this.ltview_Categoria);
            this.tab_Categoria.Location = new System.Drawing.Point(4, 25);
            this.tab_Categoria.Name = "tab_Categoria";
            this.tab_Categoria.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Categoria.Size = new System.Drawing.Size(933, 446);
            this.tab_Categoria.TabIndex = 1;
            this.tab_Categoria.Text = "Categoria";
            this.tab_Categoria.UseVisualStyleBackColor = true;
            // 
            // ltview_Categoria
            // 
            this.ltview_Categoria.HideSelection = false;
            this.ltview_Categoria.Location = new System.Drawing.Point(6, 0);
            this.ltview_Categoria.Name = "ltview_Categoria";
            this.ltview_Categoria.Size = new System.Drawing.Size(812, 450);
            this.ltview_Categoria.TabIndex = 0;
            this.ltview_Categoria.UseCompatibleStateImageBehavior = false;
            // 
            // tab_Cliente
            // 
            this.tab_Cliente.Controls.Add(this.btn_Cliente);
            this.tab_Cliente.Controls.Add(this.ltview_Cliente);
            this.tab_Cliente.Location = new System.Drawing.Point(4, 25);
            this.tab_Cliente.Name = "tab_Cliente";
            this.tab_Cliente.Size = new System.Drawing.Size(933, 446);
            this.tab_Cliente.TabIndex = 2;
            this.tab_Cliente.Text = "Cliente";
            this.tab_Cliente.UseVisualStyleBackColor = true;
            // 
            // ltview_Cliente
            // 
            this.ltview_Cliente.HideSelection = false;
            this.ltview_Cliente.Location = new System.Drawing.Point(0, 0);
            this.ltview_Cliente.Name = "ltview_Cliente";
            this.ltview_Cliente.Size = new System.Drawing.Size(818, 456);
            this.ltview_Cliente.TabIndex = 0;
            this.ltview_Cliente.UseCompatibleStateImageBehavior = false;
            // 
            // tab_Itens
            // 
            this.tab_Itens.Controls.Add(this.ltview_Itens);
            this.tab_Itens.Location = new System.Drawing.Point(4, 25);
            this.tab_Itens.Name = "tab_Itens";
            this.tab_Itens.Size = new System.Drawing.Size(821, 446);
            this.tab_Itens.TabIndex = 3;
            this.tab_Itens.Text = "Itens";
            this.tab_Itens.UseVisualStyleBackColor = true;
            // 
            // ltview_Itens
            // 
            this.ltview_Itens.HideSelection = false;
            this.ltview_Itens.Location = new System.Drawing.Point(0, 0);
            this.ltview_Itens.Name = "ltview_Itens";
            this.ltview_Itens.Size = new System.Drawing.Size(935, 460);
            this.ltview_Itens.TabIndex = 0;
            this.ltview_Itens.UseCompatibleStateImageBehavior = false;
            // 
            // tab_Pedidos
            // 
            this.tab_Pedidos.Controls.Add(this.ltview_Pedidos);
            this.tab_Pedidos.Location = new System.Drawing.Point(4, 25);
            this.tab_Pedidos.Name = "tab_Pedidos";
            this.tab_Pedidos.Size = new System.Drawing.Size(931, 446);
            this.tab_Pedidos.TabIndex = 4;
            this.tab_Pedidos.Text = "Pedidos";
            this.tab_Pedidos.UseVisualStyleBackColor = true;
            // 
            // ltview_Pedidos
            // 
            this.ltview_Pedidos.HideSelection = false;
            this.ltview_Pedidos.Location = new System.Drawing.Point(0, 0);
            this.ltview_Pedidos.Name = "ltview_Pedidos";
            this.ltview_Pedidos.Size = new System.Drawing.Size(931, 456);
            this.ltview_Pedidos.TabIndex = 0;
            this.ltview_Pedidos.UseCompatibleStateImageBehavior = false;
            // 
            // tab_Produto
            // 
            this.tab_Produto.Controls.Add(this.ltview_Produto);
            this.tab_Produto.Location = new System.Drawing.Point(4, 25);
            this.tab_Produto.Name = "tab_Produto";
            this.tab_Produto.Size = new System.Drawing.Size(931, 446);
            this.tab_Produto.TabIndex = 5;
            this.tab_Produto.Text = "Produto";
            this.tab_Produto.UseVisualStyleBackColor = true;
            // 
            // ltview_Produto
            // 
            this.ltview_Produto.HideSelection = false;
            this.ltview_Produto.Location = new System.Drawing.Point(0, 3);
            this.ltview_Produto.Name = "ltview_Produto";
            this.ltview_Produto.Size = new System.Drawing.Size(931, 457);
            this.ltview_Produto.TabIndex = 0;
            this.ltview_Produto.UseCompatibleStateImageBehavior = false;
            // 
            // btn_OpenSource
            // 
            this.btn_OpenSource.Location = new System.Drawing.Point(834, 18);
            this.btn_OpenSource.Name = "btn_OpenSource";
            this.btn_OpenSource.Size = new System.Drawing.Size(75, 59);
            this.btn_OpenSource.TabIndex = 1;
            this.btn_OpenSource.UseVisualStyleBackColor = true;
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.Location = new System.Drawing.Point(838, 13);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(75, 60);
            this.btn_Cliente.TabIndex = 2;
            this.btn_Cliente.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 486);
            this.Controls.Add(this.tab_tot);
            this.Name = "Principal";
            this.Text = "Principal";
            tab_Principal.ResumeLayout(false);
            tab_Principal.PerformLayout();
            this.tab_tot.ResumeLayout(false);
            this.tab_Categoria.ResumeLayout(false);
            this.tab_Cliente.ResumeLayout(false);
            this.tab_Itens.ResumeLayout(false);
            this.tab_Pedidos.ResumeLayout(false);
            this.tab_Produto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_tot;
        private System.Windows.Forms.TabPage tab_Categoria;
        private System.Windows.Forms.TabPage tab_Cliente;
        private System.Windows.Forms.TabPage tab_Itens;
        private System.Windows.Forms.TabPage tab_Pedidos;
        private System.Windows.Forms.TabPage tab_Produto;
        private System.Windows.Forms.RadioButton rbtn_XML;
        private System.Windows.Forms.RadioButton rbtn_JSON;
        private System.Windows.Forms.RadioButton rbtn_CSV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ltview_Categoria;
        private System.Windows.Forms.ListView ltview_Cliente;
        private System.Windows.Forms.ListView ltview_Itens;
        private System.Windows.Forms.ListView ltview_Pedidos;
        private System.Windows.Forms.ListView ltview_Produto;
        private System.Windows.Forms.Button btn_OpenSource;
        private System.Windows.Forms.Button btn_Cliente;
    }
}