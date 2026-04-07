namespace FullSoundApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnTabCliente = new System.Windows.Forms.Button();
            this.btnTabAgenda = new System.Windows.Forms.Button();
            this.btnTabOrcamentos = new System.Windows.Forms.Button();
            this.tabIndicator = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.mtxHora = new System.Windows.Forms.MaskedTextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.lblTipoServico = new System.Windows.Forms.Label();
            this.comboTipoServico = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bntTabHome = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelLista = new System.Windows.Forms.Panel();
            this.panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Orange;
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 58);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Full Sound";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnTabCliente
            // 
            this.btnTabCliente.FlatAppearance.BorderSize = 0;
            this.btnTabCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabCliente.Location = new System.Drawing.Point(39, 132);
            this.btnTabCliente.Name = "btnTabCliente";
            this.btnTabCliente.Size = new System.Drawing.Size(100, 28);
            this.btnTabCliente.TabIndex = 1;
            this.btnTabCliente.Text = "Cliente";
            // 
            // btnTabAgenda
            // 
            this.btnTabAgenda.FlatAppearance.BorderSize = 0;
            this.btnTabAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabAgenda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabAgenda.Location = new System.Drawing.Point(39, 166);
            this.btnTabAgenda.Name = "btnTabAgenda";
            this.btnTabAgenda.Size = new System.Drawing.Size(100, 28);
            this.btnTabAgenda.TabIndex = 2;
            this.btnTabAgenda.Text = "Agenda";
            this.btnTabAgenda.Click += new System.EventHandler(this.btnTabAgenda_Click);
            // 
            // btnTabOrcamentos
            // 
            this.btnTabOrcamentos.FlatAppearance.BorderSize = 0;
            this.btnTabOrcamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabOrcamentos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabOrcamentos.Location = new System.Drawing.Point(39, 205);
            this.btnTabOrcamentos.Name = "btnTabOrcamentos";
            this.btnTabOrcamentos.Size = new System.Drawing.Size(120, 28);
            this.btnTabOrcamentos.TabIndex = 3;
            this.btnTabOrcamentos.Text = "Orçamentos";
            // 
            // tabIndicator
            // 
            this.tabIndicator.BackColor = System.Drawing.Color.Orange;
            this.tabIndicator.Location = new System.Drawing.Point(39, 196);
            this.tabIndicator.Name = "tabIndicator";
            this.tabIndicator.Size = new System.Drawing.Size(100, 3);
            this.tabIndicator.TabIndex = 4;
            this.tabIndicator.Visible = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(247, 68);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 15);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(246, 170);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 15);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora";
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPesquisar.ForeColor = System.Drawing.Color.White;
            this.lblPesquisar.Location = new System.Drawing.Point(246, 119);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(59, 15);
            this.lblPesquisar.TabIndex = 9;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // dtpData
            // 
            this.dtpData.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpData.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpData.Location = new System.Drawing.Point(247, 86);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(160, 23);
            this.dtpData.TabIndex = 6;
            // 
            // mtxHora
            // 
            this.mtxHora.AsciiOnly = true;
            this.mtxHora.BackColor = System.Drawing.Color.White;
            this.mtxHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxHora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mtxHora.ForeColor = System.Drawing.Color.Black;
            this.mtxHora.Location = new System.Drawing.Point(249, 188);
            this.mtxHora.Mask = "00:00";
            this.mtxHora.Name = "mtxHora";
            this.mtxHora.Size = new System.Drawing.Size(60, 23);
            this.mtxHora.TabIndex = 8;
            this.mtxHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.White;
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPesquisar.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisar.Location = new System.Drawing.Point(249, 137);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(170, 23);
            this.txtPesquisar.TabIndex = 10;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // panelFiltro
            // 
            this.panelFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltro.Controls.Add(this.lblTipoServico);
            this.panelFiltro.Controls.Add(this.comboTipoServico);
            this.panelFiltro.Controls.Add(this.btnPesquisar);
            this.panelFiltro.Location = new System.Drawing.Point(544, 68);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Padding = new System.Windows.Forms.Padding(16);
            this.panelFiltro.Size = new System.Drawing.Size(424, 106);
            this.panelFiltro.TabIndex = 11;
            // 
            // lblTipoServico
            // 
            this.lblTipoServico.AutoSize = true;
            this.lblTipoServico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoServico.ForeColor = System.Drawing.Color.Black;
            this.lblTipoServico.Location = new System.Drawing.Point(22, 18);
            this.lblTipoServico.Name = "lblTipoServico";
            this.lblTipoServico.Size = new System.Drawing.Size(94, 15);
            this.lblTipoServico.TabIndex = 0;
            this.lblTipoServico.Text = "Tipo de serviço:";
            // 
            // comboTipoServico
            // 
            this.comboTipoServico.BackColor = System.Drawing.Color.White;
            this.comboTipoServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoServico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboTipoServico.ForeColor = System.Drawing.Color.Black;
            this.comboTipoServico.IntegralHeight = false;
            this.comboTipoServico.ItemHeight = 15;
            this.comboTipoServico.Location = new System.Drawing.Point(25, 42);
            this.comboTipoServico.MaxDropDownItems = 6;
            this.comboTipoServico.Name = "comboTipoServico";
            this.comboTipoServico.Size = new System.Drawing.Size(220, 23);
            this.comboTipoServico.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.Location = new System.Drawing.Point(265, 41);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(138, 32);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // bntTabHome
            // 
            this.bntTabHome.FlatAppearance.BorderSize = 0;
            this.bntTabHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntTabHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bntTabHome.Location = new System.Drawing.Point(39, 93);
            this.bntTabHome.Name = "bntTabHome";
            this.bntTabHome.Size = new System.Drawing.Size(100, 28);
            this.bntTabHome.TabIndex = 13;
            this.bntTabHome.Text = "Home";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 300);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panelLista
            // 
            this.panelLista.BackColor = System.Drawing.Color.DarkOrange;
            this.panelLista.Controls.Add(this.dataGridView1);
            this.panelLista.Location = new System.Drawing.Point(244, 248);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(724, 300);
            this.panelLista.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(980, 560);
            this.Controls.Add(this.bntTabHome);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnTabCliente);
            this.Controls.Add(this.btnTabAgenda);
            this.Controls.Add(this.btnTabOrcamentos);
            this.Controls.Add(this.tabIndicator);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.mtxHora);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.panelLista);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(880, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Full Sound - Agenda";
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelLista.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnTabCliente;
        private System.Windows.Forms.Button btnTabAgenda;
        private System.Windows.Forms.Button btnTabOrcamentos;
        private System.Windows.Forms.Panel tabIndicator;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.MaskedTextBox mtxHora;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel panelFiltro;
        private System.Windows.Forms.Label lblTipoServico;
        private System.Windows.Forms.ComboBox comboTipoServico;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bntTabHome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelLista;
    }
}
