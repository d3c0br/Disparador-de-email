namespace smtp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnListaDestinatarios = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.txtPorta = new System.Windows.Forms.ComboBox();
            this.txtSmtp = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtIntervalo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntervalo)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Black;
            this.txtSenha.ForeColor = System.Drawing.Color.LightGray;
            this.txtSenha.Location = new System.Drawing.Point(62, 58);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '$';
            this.txtSenha.Size = new System.Drawing.Size(329, 22);
            this.txtSenha.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // txtEmailFrom
            // 
            this.txtEmailFrom.BackColor = System.Drawing.Color.Black;
            this.txtEmailFrom.ForeColor = System.Drawing.Color.LightGray;
            this.txtEmailFrom.Location = new System.Drawing.Point(62, 26);
            this.txtEmailFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailFrom.Name = "txtEmailFrom";
            this.txtEmailFrom.Size = new System.Drawing.Size(329, 22);
            this.txtEmailFrom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "SMTP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Porta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Para:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(631, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "segundos";
            // 
            // btnListaDestinatarios
            // 
            this.btnListaDestinatarios.BackColor = System.Drawing.Color.Black;
            this.btnListaDestinatarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnListaDestinatarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnListaDestinatarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaDestinatarios.ForeColor = System.Drawing.Color.LightGray;
            this.btnListaDestinatarios.Location = new System.Drawing.Point(62, 77);
            this.btnListaDestinatarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListaDestinatarios.Name = "btnListaDestinatarios";
            this.btnListaDestinatarios.Size = new System.Drawing.Size(329, 28);
            this.btnListaDestinatarios.TabIndex = 0;
            this.btnListaDestinatarios.Text = "Buscar lista de emails...";
            this.btnListaDestinatarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaDestinatarios.UseVisualStyleBackColor = false;
            this.btnListaDestinatarios.Click += new System.EventHandler(this.btnListaDestinatarios_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(23, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(463, 585);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.btnAnexo);
            this.groupBox4.ForeColor = System.Drawing.Color.Lime;
            this.groupBox4.Location = new System.Drawing.Point(36, 133);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(355, 212);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Anexos";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 96);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 112);
            this.listBox1.TabIndex = 22;
            // 
            // btnAnexo
            // 
            this.btnAnexo.BackColor = System.Drawing.Color.Black;
            this.btnAnexo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAnexo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnexo.ForeColor = System.Drawing.Color.LightGray;
            this.btnAnexo.Location = new System.Drawing.Point(6, 23);
            this.btnAnexo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(134, 28);
            this.btnAnexo.TabIndex = 21;
            this.btnAnexo.Text = "Adicionar Arquivo";
            this.btnAnexo.UseVisualStyleBackColor = false;
            this.btnAnexo.Click += new System.EventHandler(this.brnAnexo_Click);
            // 
            // txtPorta
            // 
            this.txtPorta.BackColor = System.Drawing.Color.Black;
            this.txtPorta.ForeColor = System.Drawing.Color.LightGray;
            this.txtPorta.FormattingEnabled = true;
            this.txtPorta.Items.AddRange(new object[] {
            "25",
            "465",
            "587"});
            this.txtPorta.Location = new System.Drawing.Point(62, 90);
            this.txtPorta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(67, 24);
            this.txtPorta.TabIndex = 26;
            this.txtPorta.Text = "587";
            // 
            // txtSmtp
            // 
            this.txtSmtp.BackColor = System.Drawing.Color.Black;
            this.txtSmtp.ForeColor = System.Drawing.Color.LightGray;
            this.txtSmtp.FormattingEnabled = true;
            this.txtSmtp.Items.AddRange(new object[] {
            "smtp-mail.outlook.com",
            "smtp.mail.yahoo.com",
            "smtp.gmail.com"});
            this.txtSmtp.Location = new System.Drawing.Point(181, 90);
            this.txtSmtp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(210, 24);
            this.txtSmtp.TabIndex = 25;
            this.txtSmtp.Text = "smtp.gmail.com";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Assunto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMensagem);
            this.groupBox3.ForeColor = System.Drawing.Color.Lime;
            this.groupBox3.Location = new System.Drawing.Point(526, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(654, 304);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mensagem HTML";
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.Black;
            this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMensagem.ForeColor = System.Drawing.Color.LightGray;
            this.txtMensagem.Location = new System.Drawing.Point(3, 19);
            this.txtMensagem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensagem.Size = new System.Drawing.Size(648, 281);
            this.txtMensagem.TabIndex = 0;
            // 
            // txtAssunto
            // 
            this.txtAssunto.BackColor = System.Drawing.Color.Black;
            this.txtAssunto.ForeColor = System.Drawing.Color.LightGray;
            this.txtAssunto.Location = new System.Drawing.Point(62, 32);
            this.txtAssunto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(329, 22);
            this.txtAssunto.TabIndex = 17;
            // 
            // lbLogs
            // 
            this.lbLogs.BackColor = System.Drawing.Color.Black;
            this.lbLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLogs.ForeColor = System.Drawing.Color.Lime;
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 16;
            this.lbLogs.Location = new System.Drawing.Point(3, 19);
            this.lbLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(648, 167);
            this.lbLogs.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLogs);
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(526, 350);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(654, 190);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logs";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Black;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.ForeColor = System.Drawing.Color.Lime;
            this.btnIniciar.Location = new System.Drawing.Point(1094, 565);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(86, 28);
            this.btnIniciar.TabIndex = 21;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(702, 575);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(372, 12);
            this.progressBar1.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(523, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Intervalo:";
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.BackColor = System.Drawing.Color.Black;
            this.txtIntervalo.ForeColor = System.Drawing.Color.LightGray;
            this.txtIntervalo.Location = new System.Drawing.Point(580, 569);
            this.txtIntervalo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIntervalo.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.txtIntervalo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(48, 22);
            this.txtIntervalo.TabIndex = 26;
            this.txtIntervalo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(50, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "by: d3c0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtPorta);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtSmtp);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtSenha);
            this.groupBox5.Controls.Add(this.txtEmailFrom);
            this.groupBox5.ForeColor = System.Drawing.Color.Lime;
            this.groupBox5.Location = new System.Drawing.Point(30, 23);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(418, 133);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SMTP";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnListaDestinatarios);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txtAssunto);
            this.groupBox6.ForeColor = System.Drawing.Color.Lime;
            this.groupBox6.Location = new System.Drawing.Point(30, 180);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(418, 374);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "EMAIL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1214, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIntervalo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPAM Email - DIRETORIA 171";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIntervalo)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnListaDestinatarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbLogs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAnexo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtIntervalo;
        private System.Windows.Forms.ComboBox txtSmtp;
        private System.Windows.Forms.ComboBox txtPorta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

