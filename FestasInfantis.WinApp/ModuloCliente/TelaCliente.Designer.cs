namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaCliente
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
            btnGravar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNome = new TextBox();
            tbEndereco = new TextBox();
            tbNumero = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(594, 392);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 46);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(694, 392);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 46);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(252, 139);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(404, 139);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 3;
            label2.Text = "Numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(252, 220);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 4;
            label3.Text = "Endereço";
            // 
            // tbNome
            // 
            tbNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbNome.Location = new Point(252, 167);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(130, 33);
            tbNome.TabIndex = 5;
            // 
            // tbEndereco
            // 
            tbEndereco.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbEndereco.Location = new Point(252, 248);
            tbEndereco.Name = "tbEndereco";
            tbEndereco.Size = new Size(282, 33);
            tbEndereco.TabIndex = 6;
            // 
            // tbNumero
            // 
            tbNumero.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbNumero.Location = new Point(404, 167);
            tbNumero.Name = "tbNumero";
            tbNumero.Size = new Size(130, 33);
            tbNumero.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(300, 46);
            label4.Name = "label4";
            label4.Size = new Size(185, 25);
            label4.TabIndex = 8;
            label4.Text = "Cadastro de Clientes";
            // 
            // TelaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(label4);
            Controls.Add(tbNumero);
            Controls.Add(tbEndereco);
            Controls.Add(tbNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNome;
        private TextBox tbEndereco;
        private TextBox tbNumero;
        private Label label4;
    }
}