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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            listaItensTema = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(246, 34);
            label1.Name = "label1";
            label1.Size = new Size(289, 45);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Temas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(218, 143);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "Descrição:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(218, 201);
            label3.Name = "label3";
            label3.Size = new Size(298, 25);
            label3.TabIndex = 3;
            label3.Text = "Quais itens serão usados no tema:";
            // 
            // listaItensTema
            // 
            listaItensTema.FormattingEnabled = true;
            listaItensTema.Location = new Point(218, 229);
            listaItensTema.Name = "listaItensTema";
            listaItensTema.Size = new Size(375, 166);
            listaItensTema.TabIndex = 4;
            // 
            // TelaTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(listaItensTema);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
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
    }
}