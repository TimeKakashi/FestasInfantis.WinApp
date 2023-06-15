namespace FestasInfantis.WinApp.ModuloFesta
{
    partial class TelaFestaFiltro
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
            panel1 = new Panel();
            rbEndereco = new RadioButton();
            rbAbertas = new RadioButton();
            rbFinalizadas = new RadioButton();
            btnGravar = new Button();
            button2 = new Button();
            rbTodas = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(rbTodas);
            panel1.Controls.Add(rbEndereco);
            panel1.Controls.Add(rbAbertas);
            panel1.Controls.Add(rbFinalizadas);
            panel1.Location = new Point(228, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 170);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // rbEndereco
            // 
            rbEndereco.AutoSize = true;
            rbEndereco.Location = new Point(63, 124);
            rbEndereco.Name = "rbEndereco";
            rbEndereco.Size = new Size(179, 19);
            rbEndereco.TabIndex = 2;
            rbEndereco.TabStop = true;
            rbEndereco.Text = "Festas com mesmo endereço";
            rbEndereco.UseVisualStyleBackColor = true;
            // 
            // rbAbertas
            // 
            rbAbertas.AutoSize = true;
            rbAbertas.Location = new Point(63, 92);
            rbAbertas.Name = "rbAbertas";
            rbAbertas.Size = new Size(114, 19);
            rbAbertas.TabIndex = 1;
            rbAbertas.TabStop = true;
            rbAbertas.Text = "Festas em aberto";
            rbAbertas.UseVisualStyleBackColor = true;
            // 
            // rbFinalizadas
            // 
            rbFinalizadas.AutoSize = true;
            rbFinalizadas.Location = new Point(63, 60);
            rbFinalizadas.Name = "rbFinalizadas";
            rbFinalizadas.Size = new Size(127, 19);
            rbFinalizadas.TabIndex = 0;
            rbFinalizadas.TabStop = true;
            rbFinalizadas.Text = "Festas já finalizadas";
            rbFinalizadas.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(711, 336);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(77, 46);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Filtrar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(711, 392);
            button2.Name = "button2";
            button2.Size = new Size(77, 46);
            button2.TabIndex = 2;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            // 
            // rbTodas
            // 
            rbTodas.AutoSize = true;
            rbTodas.Location = new Point(63, 28);
            rbTodas.Name = "rbTodas";
            rbTodas.Size = new Size(102, 19);
            rbTodas.TabIndex = 3;
            rbTodas.TabStop = true;
            rbTodas.Text = "Todas as festas";
            rbTodas.UseVisualStyleBackColor = true;
            // 
            // TelaFestaFiltro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnGravar);
            Controls.Add(panel1);
            Name = "TelaFestaFiltro";
            Text = "TelaFestaFiltro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RadioButton rbEndereco;
        private RadioButton rbAbertas;
        private RadioButton rbFinalizadas;
        private Button btnGravar;
        private Button button2;
        private RadioButton rbTodas;
    }
}