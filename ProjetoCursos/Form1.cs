using ProjetoCursos.View;
namespace ProjetoCursos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCursos frm = new FrmCadCursos();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
