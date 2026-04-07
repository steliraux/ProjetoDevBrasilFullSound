using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullSoundApp
{
    public partial class Agenda : Form
    {
        List<Agendamento> agendamentos;
        Agendamento agendamentoSelecionado;
        public Agenda()
        {
            InitializeComponent();

            comboTipoServico.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoServico.Items.Clear();
            comboTipoServico.Items.AddRange(new object[]
            {
    "Instalação",
    "Manutenção",
    "Sonorização de evento",
    "Locação de equipamentos",
    "Orçamento rápido"
            });

            comboTipoServico.SelectedIndex = -1;
            agendamentos = new List<Agendamento> {
    new Agendamento
    {
        Data = new DateTime(2026, 3, 21),
        Hora = "15:00",
        TipoServico = "Instalação",
        Valor = 400
    },
    new Agendamento
    {
        Data = new DateTime(2026, 3, 25),
        Hora = "10:00",
        TipoServico = "Manutenção",
        Valor = 200
    },
    new Agendamento
    {
        Data = new DateTime(2026, 3, 27),
        Hora = "13:00",
        TipoServico = "Instalação",
        Valor = 400
    }
};

            dgvAgendamentos.AutoGenerateColumns = true;
            dgvAgendamentos.ReadOnly = true;
            dgvAgendamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgendamentos.MultiSelect = false;
            dgvAgendamentos.DataSource = agendamentos;
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
            if (comboTipoServico.SelectedItem == null)
            {
                MessageBox.Show("Selecione um tipo de serviço.");
                return;
            }
            var tipo = comboTipoServico.SelectedItem.ToString();
            var data = dtpData.Value.Date;
            bool horaPreenchida = mtxHora.MaskCompleted;
            var hora = mtxHora.Text;
            var resultado = agendamentos
                .Where(a =>
                    a.TipoServico == tipo &&
                    a.Data.Date == data &&
                    (!horaPreenchida || a.Hora == hora)
                )
                .ToList();
            if (resultado.Count == 0)
            {
                MessageBox.Show("Nenhum agendamento encontrado.");
                return;
            }
            dgvAgendamentos.DataSource = resultado;
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
        private void btnEmitirComprovante_Click(object sender, EventArgs e)
        {
            var agendamento = dgvAgendamentos.CurrentRow?.DataBoundItem as Agendamento;
            if (agendamento == null)
            {
                MessageBox.Show("Selecione um agendamento na lista.");
                return;
            }
            string caminho = $@"C:\Users\Public\comprovante_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            PdfWriter writer = new PdfWriter(caminho);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            PdfFont fonteNegrito =
                PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            document.Add(new Paragraph("FULL SOUND - COMPROVANTE")
                .SetFont(fonteNegrito)
                .SetFontSize(18));
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph($"Data: {agendamento.Data:dd/MM/yyyy}"));
            document.Add(new Paragraph($"Hora: {agendamento.Hora}"));
            document.Add(new Paragraph($"Serviço: {agendamento.TipoServico}"));
            document.Add(new Paragraph($"Valor: R$ {agendamento.Valor:N2}"));
            document.Close();
            MessageBox.Show("Comprovante gerado com sucesso!");
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = caminho,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }
        private void dgvAgendamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    public class Agendamento
        {
            public DateTime Data { get; set; }
            public string Hora { get; set; }
            public string TipoServico { get; set; }
            public decimal Valor { get; set; }
        }
}
