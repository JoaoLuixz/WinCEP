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
            this.lbCEP = new System.Windows.Forms.Label();
            this.btnEncontraCEP = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.MtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbTituloCEP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(60, 116);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(49, 23);
            this.lbCEP.TabIndex = 0;
            this.lbCEP.Text = "CEP:";
            this.lbCEP.Click += new System.EventHandler(this.lbCEP_Click);
            // 
            // btnEncontraCEP
            // 
            this.btnEncontraCEP.Location = new System.Drawing.Point(210, 113);
            this.btnEncontraCEP.Name = "btnEncontraCEP";
            this.btnEncontraCEP.Size = new System.Drawing.Size(102, 30);
            this.btnEncontraCEP.TabIndex = 2;
            this.btnEncontraCEP.Text = "Buscar";
            this.btnEncontraCEP.UseVisualStyleBackColor = true;
            this.btnEncontraCEP.Click += new System.EventHandler(this.btnEncontraCEP_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(108, 149);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(396, 30);
            this.txtEndereco.TabIndex = 2;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(108, 185);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(396, 30);
            this.txtCidade.TabIndex = 3;
            // 
            // MtxtCEP
            // 
            this.MtxtCEP.Location = new System.Drawing.Point(108, 113);
            this.MtxtCEP.Mask = "00000-000";
            this.MtxtCEP.Name = "MtxtCEP";
            this.MtxtCEP.Size = new System.Drawing.Size(96, 30);
            this.MtxtCEP.TabIndex = 1;
            this.MtxtCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MtxtCEP_MaskInputRejected);
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(12, 152);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(96, 23);
            this.lbEndereco.TabIndex = 6;
            this.lbEndereco.Text = "Endereço:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(-2, 188);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(110, 23);
            this.lbCidade.TabIndex = 7;
            this.lbCidade.Text = "Cidade / uf:";
            // 
            // lbTituloCEP
            // 
            this.lbTituloCEP.AutoSize = true;
            this.lbTituloCEP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTituloCEP.Location = new System.Drawing.Point(189, 9);
            this.lbTituloCEP.Name = "lbTituloCEP";
            this.lbTituloCEP.Size = new System.Drawing.Size(192, 23);
            this.lbTituloCEP.TabIndex = 8;
            this.lbTituloCEP.Text = "Encontra CEP 3000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 422);
            this.Controls.Add(this.lbTituloCEP);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.MtxtCEP);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.btnEncontraCEP);
            this.Controls.Add(this.lbCEP);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}