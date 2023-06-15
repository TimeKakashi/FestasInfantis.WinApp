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
            lbItens = new ListBox();
            tbValor = new TextBox();
            tbItem = new TextBox();
            btnCadastrar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 0;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(41, 21);
            label2.TabIndex = 1;
            label2.Text = "Item";
            // 
            // lbItens
            // 
            lbItens.BackColor = SystemColors.ButtonFace;
            lbItens.FormattingEnabled = true;
            lbItens.ItemHeight = 15;
            lbItens.Location = new Point(12, 175);
            lbItens.Name = "lbItens";
            lbItens.Size = new Size(312, 184);
            lbItens.TabIndex = 3;
            // 
            // tbValor
            // 
            tbValor.BackColor = SystemColors.ButtonFace;
            tbValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbValor.Location = new Point(84, 111);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 29);
            tbValor.TabIndex = 4;
            // 
            // tbItem
            // 
            tbItem.BackColor = SystemColors.ButtonFace;
            tbItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbItem.Location = new Point(84, 48);
            tbItem.Name = "tbItem";
            tbItem.Size = new Size(100, 29);
            tbItem.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadastrar.BackColor = SystemColors.ButtonFace;
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(354, 256);
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
            btnSair.Location = new Point(354, 318);
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
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(443, 371);
            Controls.Add(btnSair);
            Controls.Add(btnCadastrar);
            Controls.Add(tbItem);
            Controls.Add(tbValor);
            Controls.Add(lbItens);
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
        private ListBox lbItens;
        private TextBox tbValor;
        private TextBox tbItem;
        private Button btnCadastrar;
        private Button btnSair;
    }
}