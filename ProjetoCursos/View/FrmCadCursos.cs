using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCursos.Controller;
using ProjetoCursos.Model.DTO;

namespace ProjetoCursos.View
{
    public partial class FrmCadCursos : Form
    {
        public FrmCadCursos()
        {
            InitializeComponent();
        }

        private void BtnBarraSalvar_Click(object sender, EventArgs e)
        {
            string nomedocurso = "", turma = "", tipo = "", status = "";
            int idcurso = 0;
            string stridcurso = "";
            bool resultadosalvar = true;

            //Validar os campos
            //Verificar se o nome do curso está preenchido
            nomedocurso = TxtNomeCurso.Text;
            if (nomedocurso == "")
            {
                MessageBox.Show("O nome do curso é obrigatório!!!");
                TxtNomeCurso.Focus();
                return;
            }
            //Verificar se uma turma foi selecionada
            if (CmbTurma.SelectedIndex == -1)
            {
                MessageBox.Show("A turma é obrigatória!!!");
                CmbTurma.Focus();
                return;
            }
            //Recuperacao dos Dados
            //Recuperando o ID do Curso
            stridcurso = TxtIdCurso.Text;
            turma = CmbTurma.Text;
            if (RdWeb.Checked == true)
            {
                tipo = "Web";
            }
            else
            {
                tipo = "Mobile";
            }
            if (RdAtivo.Checked == true)
            {
                status = "Ativado";
            }
            else
            {
                status = "Desativado";
            }

            CursoController cursocontroller = new CursoController();
            //Tomar a decisão se vamos SALVAR ou ATUALIZAR
            //Se stridcurso estiver vazio, iremos SALVAR
            //Se estiver preenchido, iremos ATUALIZAR
            if (stridcurso == "")
            {
                resultadosalvar = cursocontroller.SalvarCurso(nomedocurso, turma, tipo, status);
            }
            else
            {
                idcurso = Convert.ToInt32(stridcurso);
                resultadosalvar = cursocontroller.AtualizarCurso(idcurso, nomedocurso, turma, tipo, status);
            }
            if (resultadosalvar == true)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao salvar os dados");
            }
            LimparCampos();

        }

        private void BtnBarraListar_Click(object sender, EventArgs e)
        {
            //Criar um vetor de strings
            string[] dados = new string[5];
            //Evitar que colunas sejam geradas automaticamente
            DgvCursos.AutoGenerateColumns = false;
            //Limpar o DataGridView
            DgvCursos.Rows.Clear();

            CursoController cursoController = new CursoController();
            List<CursoDTO> listadecursos = cursoController.ListarCursos();
            foreach (CursoDTO cursodto in listadecursos)
            {
                dados[0] = cursodto.IdCurso.ToString();
                dados[1] = cursodto.Nomecurso;
                dados[2] = cursodto.Turma;
                dados[3] = cursodto.Tipo;
                dados[4] = cursodto.Status;
                DgvCursos.Rows.Add(dados);
            }
        }

        private void DgvCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idcurso = "", nomecurso = "", turma = "", tipo = "", status = "";

            //Recuperando os dados da linha clicada, atribuindo às variáveis
            idcurso = DgvCursos.Rows[e.RowIndex].Cells[0].Value.ToString();
            nomecurso = DgvCursos.Rows[e.RowIndex].Cells[1].Value.ToString();
            turma = DgvCursos.Rows[e.RowIndex].Cells[2].Value.ToString();
            tipo = DgvCursos.Rows[e.RowIndex].Cells[3].Value.ToString();
            status = DgvCursos.Rows[e.RowIndex].Cells[4].Value.ToString();
            //Preencher a Tela com os dados das variáveis
            //ID do Curso
            TxtIdCurso.Text = idcurso;
            //Nome do Curso
            TxtNomeCurso.Text = nomecurso;
            //Turma      
            switch (turma)
            {
                case "MANHÃ":
                    CmbTurma.SelectedIndex = 0;
                    break;
                case "TARDE":
                    CmbTurma.SelectedIndex = 1;
                    break;
                case "NOITE":
                    CmbTurma.SelectedIndex = 2;
                    break;
            }
            if (tipo == "Web")
            {
                RdWeb.Checked = true;
            }
            else
            {
                RdMobile.Checked = true;
            }

            if(status == "Ativado")
            {
                RdAtivo.Checked = true;
            }
            else 
            {
                RdDesativado.Checked = true;
            }


        }

        private void BtnBarraApagar_Click(object sender, EventArgs e)
        {
            //Verificar se o Campo de ID tá preenchido
            string stridcurso = "";
            int idcurso = 0;
            bool resultadodelecao = false;

            stridcurso = TxtIdCurso.Text;
            if (stridcurso == "")
            {
                MessageBox.Show("Nenhum registro escolhido para deleção!!");
            }
            else
            {
                //DELETAR UM CURSO
                idcurso = Convert.ToInt32(stridcurso);
                CursoController cursocontroller = new CursoController();
                resultadodelecao = cursocontroller.DeletarCurso(idcurso);
                if (resultadodelecao)
                {
                    MessageBox.Show("Dados deletados com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao deletar um curso");
                }
                LimparCampos();
            }
        }

        //Limpar Campos
        public void LimparCampos()
        {
            //Limpar os Campos e deixar a tela em estado inicial
            TxtIdCurso.Text = "";
            TxtNomeCurso.Text = "";
            CmbTurma.SelectedIndex = -1;
            RdWeb.Checked = true;
            RdAtivo.Checked = true;
            TxtNomeCurso.Focus();
        }

        private void BtnBarraNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
