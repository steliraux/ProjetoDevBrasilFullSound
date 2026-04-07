using System;
using System.Drawing;
using System.Windows.Forms;

namespace FullSoundApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboTipoServico.Items.AddRange(new object[]
            {
                "Instalação",
                "Manutenção",
                "Sonorização de evento",
                "Locação de equipamentos",
                "Orçamento rápido"
            });
            if (comboTipoServico.Items.Count > 0)
                comboTipoServico.SelectedIndex = 0;
            btnPesquisar.Click += btnPesquisar_Click;
            btnPesquisar.MouseEnter += (s, e) => btnPesquisar.BackColor = Color.Silver;
            btnPesquisar.MouseLeave += (s, e) => btnPesquisar.BackColor = Color.Gainsboro;
            panelFiltro.Paint += panelFiltro_Paint;
            btnTabCliente.Click += (s, e) => SetSelectedTab(btnTabCliente);
            btnTabAgenda.Click += (s, e) => SetSelectedTab(btnTabAgenda);
            btnTabOrcamentos.Click += (s, e) => SetSelectedTab(btnTabOrcamentos);
            SetSelectedTab(btnTabAgenda);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var tipo = comboTipoServico.SelectedItem?.ToString() ?? "(nenhum)";
            var data = dtpData.Value.ToString("dd/MM/yyyy");
            var hora = mtxHora.Text;
            var termo = txtPesquisar.Text;
            MessageBox.Show($@"Pesquisar por: {tipo}
Data: {data}
Hora: {hora}
Termo: {termo}", "Simulação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SetSelectedTab(Button selected)
        {
            Color selBack = Color.Gainsboro;
            Color selFore = Color.Black;
            Color unsBack = Color.FromArgb(60, 60, 60);
            Color unsFore = Color.White;

            foreach (var ctrl in new[] { btnTabCliente, btnTabAgenda, btnTabOrcamentos })
            {
                if (ctrl == selected)
                {
                    ctrl.BackColor = selBack;
                    ctrl.ForeColor = selFore;
                }
                else
                {
                    ctrl.BackColor = unsBack;
                    ctrl.ForeColor = unsFore;
                }
            }

            tabIndicator.Width = selected.Width;
            tabIndicator.Left = selected.Left;
            tabIndicator.Top = selected.Bottom + 2;
            tabIndicator.Visible = true;
        }
        private void panelFiltro_Paint(object sender, PaintEventArgs e)
        {
            var rect = panelFiltro.ClientRectangle;
            rect.Inflate(-1, -1);
            ControlPaint.DrawBorder3D(e.Graphics, rect, Border3DStyle.Raised);
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTabAgenda_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
