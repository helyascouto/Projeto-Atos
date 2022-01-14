namespace SistemaControleFila
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.tmRelogio = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbExame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPaciente = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lbnHoras = new System.Windows.Forms.Label();
            this.lbnData = new System.Windows.Forms.Label();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCorfirma = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmRelogio
            // 
            this.tmRelogio.Enabled = true;
            this.tmRelogio.Tick += new System.EventHandler(this.tmRelogio_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.dgvDados);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.lbnHoras);
            this.groupBox3.Controls.Add(this.lbnData);
            this.groupBox3.Controls.Add(this.BtnProximo);
            this.groupBox3.Location = new System.Drawing.Point(506, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 640);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbExame);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txbPaciente);
            this.groupBox2.Location = new System.Drawing.Point(16, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 128);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta";
            // 
            // txbExame
            // 
            this.txbExame.Location = new System.Drawing.Point(271, 56);
            this.txbExame.Name = "txbExame";
            this.txbExame.Size = new System.Drawing.Size(213, 23);
            this.txbExame.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(271, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Exame:";
            // 
            // txbPaciente
            // 
            this.txbPaciente.Location = new System.Drawing.Point(10, 56);
            this.txbPaciente.Name = "txbPaciente";
            this.txbPaciente.Size = new System.Drawing.Size(213, 23);
            this.txbPaciente.TabIndex = 13;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(16, 110);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvDados.RowTemplate.Height = 25;
            this.dgvDados.Size = new System.Drawing.Size(500, 270);
            this.dgvDados.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 53);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 83);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 23);
            this.textBox1.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(406, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 25);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Usuario:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 563);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 53);
            this.button3.TabIndex = 20;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbnHoras
            // 
            this.lbnHoras.AutoSize = true;
            this.lbnHoras.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbnHoras.Location = new System.Drawing.Point(404, 383);
            this.lbnHoras.Name = "lbnHoras";
            this.lbnHoras.Size = new System.Drawing.Size(112, 32);
            this.lbnHoras.TabIndex = 23;
            this.lbnHoras.Text = "12:45:21";
            // 
            // lbnData
            // 
            this.lbnData.AutoSize = true;
            this.lbnData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbnData.Location = new System.Drawing.Point(16, 389);
            this.lbnData.Name = "lbnData";
            this.lbnData.Size = new System.Drawing.Size(116, 25);
            this.lbnData.TabIndex = 24;
            this.lbnData.Text = "13/12/2021";
            // 
            // BtnProximo
            // 
            this.BtnProximo.Location = new System.Drawing.Point(355, 563);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(161, 53);
            this.BtnProximo.TabIndex = 21;
            this.BtnProximo.Text = "Próximo";
            this.BtnProximo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(633, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 45);
            this.label5.TabIndex = 22;
            this.label5.Text = "Controle de Filas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.btnCorfirma);
            this.groupBox4.Location = new System.Drawing.Point(39, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 640);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Location = new System.Drawing.Point(16, 98);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(370, 172);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Consulta";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 23);
            this.textBox2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome Paciente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Exame:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 23);
            this.textBox3.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(16, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(370, 83);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Login";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(101, 33);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 23);
            this.textBox4.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Paciente:";
            // 
            // btnCorfirma
            // 
            this.btnCorfirma.Location = new System.Drawing.Point(16, 561);
            this.btnCorfirma.Name = "btnCorfirma";
            this.btnCorfirma.Size = new System.Drawing.Size(370, 53);
            this.btnCorfirma.TabIndex = 21;
            this.btnCorfirma.Text = "Confirmar  Presença";
            this.btnCorfirma.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(65, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 37);
            this.label4.TabIndex = 24;
            this.label4.Text = "Confirmação de Presença";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 723);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de filas v1.0";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmRelogio;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox txbExame;
        private Label label1;
        private Label label3;
        private TextBox txbPaciente;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button btnBuscar;
        private Label label2;
        private DataGridView dgvDados;
        private Label lbnData;
        private Label label5;
        private Label lbnHoras;
        private Button button1;
        private Button button3;
        private Button BtnProximo;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private GroupBox groupBox6;
        private TextBox textBox4;
        private Button button4;
        private Label label8;
        private Button btnCorfirma;
        private Label label4;
    }
}