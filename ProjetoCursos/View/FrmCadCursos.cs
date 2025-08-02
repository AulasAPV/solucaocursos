using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            bool resultadosalvar = true;


            //Recuperacao dos Dados
            //Recuperando o ID do Curso
            idcurso = Convert.ToInt32(TxtIdCurso.Text);
            nomedocurso = TxtNomeCurso.Text;
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
            if (idcurso == 0) 
            {
                resultadosalvar = cursocontroller.SalvarCurso(nomedocurso, turma, tipo, status);
            }
            else
            {
                resultadosalvar = cursocontroller.AtualizarCurso(idcurso,nomedocurso, turma, tipo, status);
            }
            if (resultadosalvar == true)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao salvar os dados");
            }

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
                //MessageBox.Show(cursodto.Nomecurso);
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


        }
    }
}
