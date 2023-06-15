namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaItens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaItens));
            label1 = new Label();
            label2 = new Label();
            tbValor = new TextBox();
            tbItem = new TextBox();
            btnCadastrar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 0;
            label1.Text = "Valor :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 1;
            label2.Text = "Item :";
            label2.Click += label2_Click;
            // 
            // tbItem
            // 
            tbItem.BackColor = SystemColors.ButtonFace;
            tbItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbItem.Location = new Point(71, 38);
            tbItem.Name = "tbItem";
            tbItem.Size = new Size(207, 29);
            tbItem.TabIndex = 5;
            // 
            // tbValor
            // 
            tbValor.BackColor = SystemColors.ButtonFace;
            tbValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbValor.Location = new Point(71, 97);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(61, 29);
            tbValor.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadastrar.BackColor = SystemColors.ButtonFace;
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(152, 147);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(86, 43);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.BackColor = SystemColors.ButtonFace;
            btnSair.DialogResult = DialogResult.Cancel;
            btnSair.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Location = new Point(244, 147);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(86, 43);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // TelaItens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(344, 203);
            Controls.Add(btnSair);
            Controls.Add(btnCadastrar);
            Controls.Add(tbValor);
            Controls.Add(tbItem);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TelaItens";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Itens";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbItem;
        private TextBox tbValor;
        private Button btnCadastrar;
        private Button btnSair;
    }
}