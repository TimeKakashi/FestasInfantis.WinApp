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
            label1 = new Label();
            label2 = new Label();
            tbDescricao = new TextBox();
            label3 = new Label();
            listaItensTema = new CheckedListBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 45);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Temas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 74);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            tbDescricao.Location = new Point(241, 74);
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(143, 23);
            tbDescricao.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(104, 114);
            label3.Name = "label3";
            label3.Size = new Size(298, 25);
            label3.TabIndex = 3;
            label3.Text = "Quais itens serão usados no tema:";
            // 
            // listaItensTema
            // 
            listaItensTema.FormattingEnabled = true;
            listaItensTema.Location = new Point(143, 160);
            listaItensTema.Name = "listaItensTema";
            listaItensTema.Size = new Size(229, 184);
            listaItensTema.TabIndex = 4;
            listaItensTema.ItemCheck += listaItensTema_ItemCheck;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(409, 262);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(93, 38);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(409, 321);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 38);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TelaTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(514, 371);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(listaItensTema);
            Controls.Add(label3);
            Controls.Add(tbDescricao);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaTema";
            Text = "TelaTema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private CheckedListBox listaItensTema;
        private TextBox tbDescricao;
        private Button btnGravar;
        private Button btnCancelar;
    }
}