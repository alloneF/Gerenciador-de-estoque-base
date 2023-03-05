namespace Gerenciador_de_estoque_base
{
    partial class gerStq
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.porcura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idprod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbProd = new System.Windows.Forms.GroupBox();
            this.com = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ven = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stq = new System.Windows.Forms.TextBox();
            this.comp = new System.Windows.Forms.Button();
            this.Tpreco = new System.Windows.Forms.Button();
            this.vendid = new System.Windows.Forms.Button();
            this.valo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbProd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // porcura
            // 
            this.porcura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.porcura.Location = new System.Drawing.Point(106, 173);
            this.porcura.Name = "porcura";
            this.porcura.Size = new System.Drawing.Size(105, 37);
            this.porcura.TabIndex = 0;
            this.porcura.Text = "Procurar";
            this.porcura.UseVisualStyleBackColor = true;
            this.porcura.Click += new System.EventHandler(this.porcura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerenciador de Estoque";
            // 
            // idprod
            // 
            this.idprod.Location = new System.Drawing.Point(195, 123);
            this.idprod.Name = "idprod";
            this.idprod.Size = new System.Drawing.Size(118, 26);
            this.idprod.TabIndex = 2;
            this.idprod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quant. em estoque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Insira o ID do produto:";
            // 
            // gbProd
            // 
            this.gbProd.Controls.Add(this.com);
            this.gbProd.Controls.Add(this.label5);
            this.gbProd.Controls.Add(this.ven);
            this.gbProd.Controls.Add(this.label4);
            this.gbProd.Controls.Add(this.stq);
            this.gbProd.Controls.Add(this.label2);
            this.gbProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbProd.Location = new System.Drawing.Point(449, 29);
            this.gbProd.Name = "gbProd";
            this.gbProd.Size = new System.Drawing.Size(330, 181);
            this.gbProd.TabIndex = 5;
            this.gbProd.TabStop = false;
            this.gbProd.Text = "Nenhum produto selecionado";
            // 
            // com
            // 
            this.com.Location = new System.Drawing.Point(219, 116);
            this.com.Name = "com";
            this.com.ReadOnly = true;
            this.com.Size = new System.Drawing.Size(83, 26);
            this.com.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor de compra (unitário):";
            // 
            // ven
            // 
            this.ven.Location = new System.Drawing.Point(219, 73);
            this.ven.Name = "ven";
            this.ven.ReadOnly = true;
            this.ven.Size = new System.Drawing.Size(83, 26);
            this.ven.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor de venda (unitário):";
            // 
            // stq
            // 
            this.stq.Location = new System.Drawing.Point(219, 34);
            this.stq.Name = "stq";
            this.stq.ReadOnly = true;
            this.stq.Size = new System.Drawing.Size(83, 26);
            this.stq.TabIndex = 6;
            this.stq.TextChanged += new System.EventHandler(this.stq_TextChanged);
            // 
            // comp
            // 
            this.comp.BackColor = System.Drawing.Color.ForestGreen;
            this.comp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comp.Location = new System.Drawing.Point(302, 80);
            this.comp.Name = "comp";
            this.comp.Size = new System.Drawing.Size(105, 37);
            this.comp.TabIndex = 6;
            this.comp.Text = "Comprar";
            this.comp.UseVisualStyleBackColor = false;
            this.comp.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tpreco
            // 
            this.Tpreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(72)))));
            this.Tpreco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tpreco.Location = new System.Drawing.Point(191, 37);
            this.Tpreco.Name = "Tpreco";
            this.Tpreco.Size = new System.Drawing.Size(216, 37);
            this.Tpreco.TabIndex = 7;
            this.Tpreco.Text = "Alterar preço de venda";
            this.Tpreco.UseVisualStyleBackColor = false;
            this.Tpreco.Click += new System.EventHandler(this.Tpreco_Click);
            // 
            // vendid
            // 
            this.vendid.BackColor = System.Drawing.Color.SteelBlue;
            this.vendid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vendid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vendid.Location = new System.Drawing.Point(191, 80);
            this.vendid.Name = "vendid";
            this.vendid.Size = new System.Drawing.Size(105, 37);
            this.vendid.TabIndex = 8;
            this.vendid.Text = "Vender";
            this.vendid.UseVisualStyleBackColor = false;
            this.vendid.Click += new System.EventHandler(this.vendid_Click);
            // 
            // valo
            // 
            this.valo.Location = new System.Drawing.Point(38, 71);
            this.valo.Name = "valo";
            this.valo.Size = new System.Drawing.Size(118, 26);
            this.valo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor da operação:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tpreco);
            this.groupBox1.Controls.Add(this.comp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.vendid);
            this.groupBox1.Controls.Add(this.valo);
            this.groupBox1.Location = new System.Drawing.Point(185, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 138);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // gerStq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idprod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.porcura);
            this.Name = "gerStq";
            this.Text = "Form1";
            this.gbProd.ResumeLayout(false);
            this.gbProd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button porcura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idprod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbProd;
        private System.Windows.Forms.TextBox com;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ven;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stq;
        private System.Windows.Forms.Button comp;
        private System.Windows.Forms.Button Tpreco;
        private System.Windows.Forms.Button vendid;
        private System.Windows.Forms.TextBox valo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

