namespace FullSoundApp
{
    partial class Agenda
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            btnTabCliente = new Button();
            btnTabAgenda = new Button();
            btnTabOrcamentos = new Button();
            tabIndicator = new Panel();
            lblData = new Label();
            lblHora = new Label();
            lblPesquisar = new Label();
            dtpData = new DateTimePicker();
            mtxHora = new MaskedTextBox();
            txtPesquisar = new TextBox();
            panelFiltro = new Panel();
            label10 = new Label();
            btnEmitirComprovante = new Button();
            lblTipoServico = new Label();
            comboTipoServico = new ComboBox();
            btnPesquisar = new Button();
            dgvAgendamentos = new DataGridView();
            toolTip1 = new ToolTip(components);
            bntTabHome = new Button();
            label14 = new Label();
            panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Orange;
            lblTitulo.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblTitulo.Location = new Point(89, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(140, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sound";
            // 
            // btnTabCliente
            // 
            btnTabCliente.FlatAppearance.BorderSize = 0;
            btnTabCliente.FlatStyle = FlatStyle.Flat;
            btnTabCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTabCliente.Location = new Point(39, 132);
            btnTabCliente.Name = "btnTabCliente";
            btnTabCliente.Size = new Size(100, 28);
            btnTabCliente.TabIndex = 1;
            btnTabCliente.Text = "Cliente";
            // 
            // btnTabAgenda
            // 
            btnTabAgenda.FlatAppearance.BorderSize = 0;
            btnTabAgenda.FlatStyle = FlatStyle.Flat;
            btnTabAgenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTabAgenda.Location = new Point(39, 166);
            btnTabAgenda.Name = "btnTabAgenda";
            btnTabAgenda.Size = new Size(100, 28);
            btnTabAgenda.TabIndex = 2;
            btnTabAgenda.Text = "Agenda";
            // 
            // btnTabOrcamentos
            // 
            btnTabOrcamentos.FlatAppearance.BorderSize = 0;
            btnTabOrcamentos.FlatStyle = FlatStyle.Flat;
            btnTabOrcamentos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTabOrcamentos.Location = new Point(30, 205);
            btnTabOrcamentos.Name = "btnTabOrcamentos";
            btnTabOrcamentos.Size = new Size(120, 28);
            btnTabOrcamentos.TabIndex = 3;
            btnTabOrcamentos.Text = "Orçamentos";
            // 
            // tabIndicator
            // 
            tabIndicator.BackColor = Color.Orange;
            tabIndicator.Location = new Point(53, 170);
            tabIndicator.Name = "tabIndicator";
            tabIndicator.Size = new Size(10, 21);
            tabIndicator.TabIndex = 4;
            tabIndicator.Visible = false;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.BackColor = Color.Black;
            lblData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblData.ForeColor = Color.Transparent;
            lblData.Location = new Point(41, 115);
            lblData.Name = "lblData";
            lblData.Size = new Size(33, 15);
            lblData.TabIndex = 5;
            lblData.Text = "Data";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Black;
            lblHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHora.ForeColor = Color.Transparent;
            lblHora.Location = new Point(41, 208);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(34, 15);
            lblHora.TabIndex = 7;
            lblHora.Text = "Hora";
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.BackColor = Color.Black;
            lblPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPesquisar.ForeColor = Color.Transparent;
            lblPesquisar.Location = new Point(41, 166);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(59, 15);
            lblPesquisar.TabIndex = 9;
            lblPesquisar.Text = "Pesquisar";
            // 
            // dtpData
            // 
            dtpData.CalendarForeColor = Color.Black;
            dtpData.CalendarMonthBackground = Color.White;
            dtpData.Font = new Font("Segoe UI", 9F);
            dtpData.Location = new Point(41, 133);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(160, 23);
            dtpData.TabIndex = 6;
            // 
            // mtxHora
            // 
            mtxHora.AsciiOnly = true;
            mtxHora.BackColor = Color.White;
            mtxHora.BorderStyle = BorderStyle.FixedSingle;
            mtxHora.Font = new Font("Segoe UI", 9F);
            mtxHora.ForeColor = Color.Black;
            mtxHora.Location = new Point(41, 226);
            mtxHora.Mask = "00:00";
            mtxHora.Name = "mtxHora";
            mtxHora.Size = new Size(60, 23);
            mtxHora.TabIndex = 8;
            mtxHora.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPesquisar
            // 
            txtPesquisar.BackColor = Color.White;
            txtPesquisar.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisar.Font = new Font("Segoe UI", 9F);
            txtPesquisar.ForeColor = Color.Black;
            txtPesquisar.Location = new Point(41, 184);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(160, 23);
            txtPesquisar.TabIndex = 10;
            // 
            // panelFiltro
            // 
            panelFiltro.BackColor = Color.Black;
            panelFiltro.BorderStyle = BorderStyle.FixedSingle;
            panelFiltro.Controls.Add(label10);
            panelFiltro.Controls.Add(btnEmitirComprovante);
            panelFiltro.Controls.Add(lblTipoServico);
            panelFiltro.Controls.Add(comboTipoServico);
            panelFiltro.Controls.Add(btnPesquisar);
            panelFiltro.Controls.Add(lblData);
            panelFiltro.Controls.Add(dtpData);
            panelFiltro.Controls.Add(txtPesquisar);
            panelFiltro.Controls.Add(lblHora);
            panelFiltro.Controls.Add(lblPesquisar);
            panelFiltro.Controls.Add(mtxHora);
            panelFiltro.Controls.Add(dgvAgendamentos);
            panelFiltro.Location = new Point(246, 20);
            panelFiltro.Name = "panelFiltro";
            panelFiltro.Padding = new Padding(16);
            panelFiltro.Size = new Size(722, 528);
            panelFiltro.TabIndex = 11;
            // 
            // label10
            // 
            label10.BackColor = Color.Black;
            label10.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Orange;
            label10.Location = new Point(85, 6);
            label10.Name = "label10";
            label10.Size = new Size(160, 51);
            label10.TabIndex = 14;
            label10.Text = "Agenda";
            // 
            // btnEmitirComprovante
            // 
            btnEmitirComprovante.BackColor = Color.Orange;
            btnEmitirComprovante.FlatAppearance.BorderSize = 0;
            btnEmitirComprovante.FlatStyle = FlatStyle.Flat;
            btnEmitirComprovante.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEmitirComprovante.ForeColor = Color.Transparent;
            btnEmitirComprovante.Location = new Point(276, 464);
            btnEmitirComprovante.Name = "btnEmitirComprovante";
            btnEmitirComprovante.Size = new Size(179, 43);
            btnEmitirComprovante.TabIndex = 5;
            btnEmitirComprovante.Text = "Emitir Comprovante";
            btnEmitirComprovante.UseVisualStyleBackColor = false;
            btnEmitirComprovante.Click += btnEmitirComprovante_Click;
            // 
            // lblTipoServico
            // 
            lblTipoServico.AutoSize = true;
            lblTipoServico.BackColor = Color.Black;
            lblTipoServico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipoServico.ForeColor = Color.Transparent;
            lblTipoServico.Location = new Point(41, 72);
            lblTipoServico.Name = "lblTipoServico";
            lblTipoServico.Size = new Size(94, 15);
            lblTipoServico.TabIndex = 0;
            lblTipoServico.Text = "Tipo de serviço:";
            // 
            // comboTipoServico
            // 
            comboTipoServico.BackColor = Color.White;
            comboTipoServico.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoServico.Font = new Font("Segoe UI", 9F);
            comboTipoServico.ForeColor = Color.Black;
            comboTipoServico.IntegralHeight = false;
            comboTipoServico.ItemHeight = 15;
            comboTipoServico.Location = new Point(41, 90);
            comboTipoServico.MaxDropDownItems = 6;
            comboTipoServico.Name = "comboTipoServico";
            comboTipoServico.Size = new Size(158, 23);
            comboTipoServico.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Orange;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPesquisar.ForeColor = Color.Transparent;
            btnPesquisar.Location = new Point(439, 129);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(138, 32);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // dgvAgendamentos
            // 
            dgvAgendamentos.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAgendamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAgendamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAgendamentos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAgendamentos.Location = new Point(31, 291);
            dgvAgendamentos.Name = "dgvAgendamentos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAgendamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAgendamentos.Size = new Size(680, 225);
            dgvAgendamentos.TabIndex = 14;
            dgvAgendamentos.CellContentClick += dgvAgendamentos_CellContentClick;
            // 
            // bntTabHome
            // 
            bntTabHome.FlatAppearance.BorderSize = 0;
            bntTabHome.FlatStyle = FlatStyle.Flat;
            bntTabHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bntTabHome.Location = new Point(39, 93);
            bntTabHome.Name = "bntTabHome";
            bntTabHome.Size = new Size(100, 28);
            bntTabHome.TabIndex = 13;
            bntTabHome.Text = "Home";
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Transparent;
            label14.Location = new Point(12, 20);
            label14.Name = "label14";
            label14.Size = new Size(85, 58);
            label14.TabIndex = 14;
            label14.Text = "Full";
            // 
            // Agenda
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(980, 560);
            Controls.Add(label14);
            Controls.Add(lblTitulo);
            Controls.Add(bntTabHome);
            Controls.Add(btnTabCliente);
            Controls.Add(btnTabOrcamentos);
            Controls.Add(tabIndicator);
            Controls.Add(panelFiltro);
            Controls.Add(btnTabAgenda);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            MinimumSize = new Size(880, 480);
            Name = "Agenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Full Sound - Agenda";
            panelFiltro.ResumeLayout(false);
            panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).EndInit();
            ResumeLayout(false);

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
        private Button btnEmitirComprovante;
        private Label label10;
        private DataGridView dgvAgendamentos;
        private Label label14;
    }
}
