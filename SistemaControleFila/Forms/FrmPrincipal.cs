using SistemaControleFila.Data;
using SistemaControleFila.Model;
using System.Data;

namespace SistemaControleFila
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CarregaDgvdados();
        }



        private void tmRelogio_Tick(object sender, EventArgs e)
        {
            lbnHoras.Text = DateTime.Now.ToString("HH:mm:ss");
            lbnData.Text = DateTime.Now.ToString("D");

        }

        private void lbnData_Click(object sender, EventArgs e)
        {

        }





        private void btnDelete_Click(object sender, EventArgs e)
        {
            //    Consulta programador = new Consulta();
            //    programador.id = int.Parse(txtId.Text);
            //    programador = programador.retornaConsulta(programador.id);
            //    if (programador == null)
            //    {
            //        MessageBox.Show("Erro ao excluir: O programador não foi encontrado (404)!");
            //        return;
            //    }
            //    bool retorno = programador.excluirConsulta(programador.id);
            //    if (retorno == true)
            //    {
            //        MessageBox.Show("Excluído com sucesso!");
            //        limparCampos();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Erro ao executar a exclusão!");
            //    }

        }

        //Preencher os campos com o click na linha selecionada do dataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvDados.Rows[e.RowIndex].Cells[0].Value != null)
            //{
            //    try
            //    {
            //        Consulta consulta = new Consulta();
            //        int idProgramador = int.Parse(dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            //        consulta = consulta.retornaConsulta(idProgramador);
            //        txtId.Text = consulta.id.ToString();
            //        txtNome.Text = consulta.nome;
            //        txtLinguagem.Text = consulta.linguagem;
            //        txtBanco.Text = consulta.banco;
            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine(ex.Message);
            //    }
            //}
        }

        private void limparCampos()
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    Consulta consulta = new Consulta();
            //    consulta = consulta.retornaConsulta(int.Parse(txtId.Text));
            //    if (consulta != null)
            //    {
            //        txtNome.Text = consulta.nome;
            //        txtLinguagem.Text = consulta.linguagem;
            //        txtBanco.Text = consulta.banco;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Programador não encontrado!");
            //    }

            //    //MessageBox.Show(programador.nome);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //finally
            //{
            //    Console.WriteLine("Banco fechado");
            //}
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void CarregaDgvdados()
        {
            try
            {
                Banco db = new Banco();
                string sql = "select * from dbo.ListExams";

                DataTable dt = new DataTable();
                dt = db.executarColsultaGenerica(sql);
                dgvDados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txbPaciente.Text = "";
            txbExame.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}