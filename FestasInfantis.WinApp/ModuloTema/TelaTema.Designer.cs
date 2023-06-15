namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaTema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTema));
            label2 = new Label();
            tbDescricao = new TextBox();
            label3 = new Label();
            listaItensTema = new CheckedListBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 31);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            tbDescricao.Location = new Point(132, 33);
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(143, 23);
            tbDescricao.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(298, 25);
            label3.TabIndex = 3;
            label3.Text = "Quais itens serão usados no tema:";
            // 
            // listaItensTema
            // 
            listaItensTema.FormattingEnabled = true;
            listaItensTema.Location = new Point(12, 175);
            listaItensTema.Name = "listaItensTema";
            listaItensTema.Size = new Size(312, 184);
            listaItensTema.TabIndex = 4;
            listaItensTema.ItemCheck += listaItensTema_ItemCheck;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = SystemColors.ControlLightLight;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(354, 256);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(86, 43);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Cadastrar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = SystemColors.ControlLightLight;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(354, 318);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 43);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Sair";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TelaTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(443, 371);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(listaItensTema);
            Controls.Add(label3);
            Controls.Add(tbDescricao);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TelaTema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Temas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private CheckedListBox listaItensTema;
        private TextBox tbDescricao;
        private Button btnGravar;
        private Button btnCancelar;
    }
}