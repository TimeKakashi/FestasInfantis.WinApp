namespace FestasInfantis.WinApp.ModuloFesta
{
    partial class TelaFesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFesta));
            label2 = new Label();
            cbCliente = new ComboBox();
            cbTema = new ComboBox();
            label3 = new Label();
            tbEndereco = new TextBox();
            label4 = new Label();
            label5 = new Label();
            tbValorEntrada = new TextBox();
            dtData = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            dtHoraTermino = new DateTimePicker();
            label8 = new Label();
            dtHoraInicio = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            tbSinal = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 68);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // cbCliente
            // 
            cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(138, 70);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(121, 23);
            cbCliente.TabIndex = 2;
            // 
            // cbTema
            // 
            cbTema.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTema.FormattingEnabled = true;
            cbTema.Location = new Point(138, 250);
            cbTema.Name = "cbTema";
            cbTema.Size = new Size(121, 23);
            cbTema.TabIndex = 4;
            cbTema.SelectedIndexChanged += cbTema_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 248);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 3;
            label3.Text = "Tema";
            // 
            // tbEndereco
            // 
            tbEndereco.Location = new Point(138, 295);
            tbEndereco.Name = "tbEndereco";
            tbEndereco.Size = new Size(121, 23);
            tbEndereco.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 293);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 6;
            label4.Text = "Endereço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(7, 338);
            label5.Name = "label5";
            label5.Size = new Size(124, 21);
            label5.TabIndex = 8;
            label5.Text = "Valor de entrada";
            // 
            // tbValorEntrada
            // 
            tbValorEntrada.Enabled = false;
            tbValorEntrada.Location = new Point(138, 340);
            tbValorEntrada.Name = "tbValorEntrada";
            tbValorEntrada.Size = new Size(121, 23);
            tbValorEntrada.TabIndex = 7;
            // 
            // dtData
            // 
            dtData.Format = DateTimePickerFormat.Short;
            dtData.Location = new Point(138, 115);
            dtData.Name = "dtData";
            dtData.Size = new Size(121, 23);
            dtData.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGray;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 113);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 10;
            label6.Text = "Data";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightGray;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 203);
            label7.Name = "label7";
            label7.Size = new Size(125, 21);
            label7.TabIndex = 12;
            label7.Text = "Hora do término";
            // 
            // dtHoraTermino
            // 
            dtHoraTermino.Format = DateTimePickerFormat.Time;
            dtHoraTermino.Location = new Point(138, 205);
            dtHoraTermino.Name = "dtHoraTermino";
            dtHoraTermino.Size = new Size(121, 23);
            dtHoraTermino.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightGray;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(7, 158);
            label8.Name = "label8";
            label8.Size = new Size(85, 21);
            label8.TabIndex = 14;
            label8.Text = "Hora Inicio";
            // 
            // dtHoraInicio
            // 
            dtHoraInicio.Format = DateTimePickerFormat.Time;
            dtHoraInicio.Location = new Point(138, 160);
            dtHoraInicio.Name = "dtHoraInicio";
            dtHoraInicio.Size = new Size(121, 23);
            dtHoraInicio.TabIndex = 13;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(301, 290);
            button1.Name = "button1";
            button1.Size = new Size(110, 37);
            button1.TabIndex = 15;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(301, 340);
            button2.Name = "button2";
            button2.Size = new Size(110, 37);
            button2.TabIndex = 16;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 23);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 18;
            label1.Text = "Sinal";
            // 
            // tbSinal
            // 
            tbSinal.Location = new Point(138, 25);
            tbSinal.Name = "tbSinal";
            tbSinal.Size = new Size(72, 23);
            tbSinal.TabIndex = 17;
            // 
            // TelaFesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(423, 389);
            Controls.Add(label1);
            Controls.Add(tbSinal);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(dtHoraInicio);
            Controls.Add(label7);
            Controls.Add(dtHoraTermino);
            Controls.Add(label6);
            Controls.Add(dtData);
            Controls.Add(label5);
            Controls.Add(tbValorEntrada);
            Controls.Add(label4);
            Controls.Add(tbEndereco);
            Controls.Add(cbTema);
            Controls.Add(label3);
            Controls.Add(cbCliente);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TelaFesta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Festa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox cbCliente;
        private ComboBox cbTema;
        private Label label3;
        private TextBox tbEndereco;
        private Label label4;
        private Label label5;
        private TextBox tbValorEntrada;
        private DateTimePicker dtData;
        private Label label6;
        private Label label7;
        private DateTimePicker dtHoraTermino;
        private Label label8;
        private DateTimePicker dtHoraInicio;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox tbSinal;
    }
}