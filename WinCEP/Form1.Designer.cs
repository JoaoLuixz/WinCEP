namespace WinCEP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbCEP = new Label();
            btnEncontraCEP = new Button();
            txtEndereco = new TextBox();
            txtCidade = new TextBox();
            MtxtCEP = new MaskedTextBox();
            lbEndereco = new Label();
            lbCidade = new Label();
            lbTituloCEP = new Label();
            lbComplemento = new Label();
            txtComplemento = new TextBox();
            SuspendLayout();
            // 
            // lbCEP
            // 
            lbCEP.AutoSize = true;
            lbCEP.Location = new Point(267, 65);
            lbCEP.Name = "lbCEP";
            lbCEP.Size = new Size(49, 23);
            lbCEP.TabIndex = 0;
            lbCEP.Text = "CEP:";
            lbCEP.TextAlign = ContentAlignment.MiddleCenter;
            lbCEP.Click += lbCEP_Click;
            // 
            // btnEncontraCEP
            // 
            btnEncontraCEP.Location = new Point(238, 128);
            btnEncontraCEP.Name = "btnEncontraCEP";
            btnEncontraCEP.Size = new Size(102, 30);
            btnEncontraCEP.TabIndex = 2;
            btnEncontraCEP.Text = "Buscar";
            btnEncontraCEP.UseVisualStyleBackColor = true;
            btnEncontraCEP.Click += btnEncontraCEP_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(164, 195);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(396, 30);
            txtEndereco.TabIndex = 2;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(164, 275);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(162, 30);
            txtCidade.TabIndex = 3;
            // 
            // MtxtCEP
            // 
            MtxtCEP.Location = new Point(238, 92);
            MtxtCEP.Mask = "00000-000";
            MtxtCEP.Name = "MtxtCEP";
            MtxtCEP.Size = new Size(102, 30);
            MtxtCEP.TabIndex = 1;
            MtxtCEP.MaskInputRejected += MtxtCEP_MaskInputRejected;
            // 
            // lbEndereco
            // 
            lbEndereco.AutoSize = true;
            lbEndereco.Location = new Point(62, 198);
            lbEndereco.Name = "lbEndereco";
            lbEndereco.Size = new Size(96, 23);
            lbEndereco.TabIndex = 6;
            lbEndereco.Text = "Endereço:";
            // 
            // lbCidade
            // 
            lbCidade.AutoSize = true;
            lbCidade.Location = new Point(48, 278);
            lbCidade.Name = "lbCidade";
            lbCidade.Size = new Size(110, 23);
            lbCidade.TabIndex = 7;
            lbCidade.Text = "Cidade / uf:";
            // 
            // lbTituloCEP
            // 
            lbTituloCEP.AutoSize = true;
            lbTituloCEP.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloCEP.Location = new Point(189, 9);
            lbTituloCEP.Name = "lbTituloCEP";
            lbTituloCEP.Size = new Size(192, 23);
            lbTituloCEP.TabIndex = 8;
            lbTituloCEP.Text = "Encontra CEP 3000";
            // 
            // lbComplemento
            // 
            lbComplemento.AutoSize = true;
            lbComplemento.Location = new Point(332, 278);
            lbComplemento.Name = "lbComplemento";
            lbComplemento.Size = new Size(138, 23);
            lbComplemento.TabIndex = 9;
            lbComplemento.Text = "Complemento: ";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(462, 275);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(98, 30);
            txtComplemento.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 422);
            Controls.Add(txtComplemento);
            Controls.Add(lbComplemento);
            Controls.Add(lbTituloCEP);
            Controls.Add(lbCidade);
            Controls.Add(lbEndereco);
            Controls.Add(MtxtCEP);
            Controls.Add(txtCidade);
            Controls.Add(txtEndereco);
            Controls.Add(btnEncontraCEP);
            Controls.Add(lbCEP);
            Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCEP;
        private Button btnEncontraCEP;
        private TextBox txtEndereco;
        private TextBox txtCidade;
        private MaskedTextBox MtxtCEP;
        private Label lbEndereco;
        private Label lbCidade;
        private Label lbTituloCEP;
        private Label lbComplemento;
        private TextBox txtComplemento;
    }
}