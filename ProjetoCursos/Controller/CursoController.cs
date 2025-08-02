using ProjetoCursos.Model.DAO;
using ProjetoCursos.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoCursos.Controller
{
    internal class CursoController
    {
        public bool SalvarCurso(string nomedocurso, string turma, string tipo, string status)
        {
            bool retornodao = false;
            CursoDTO cursodto = new CursoDTO(nomedocurso, turma, tipo, status);
            CursoDAO cursodao = new CursoDAO();
            retornodao = cursodao.Salvar(cursodto);
            return retornodao;
        }

        public List<CursoDTO> ListarCursos()
        {
            CursoDAO cursoDAO = new CursoDAO();
            List<CursoDTO> listadecursos = cursoDAO.Listar();
            return listadecursos;
        }

        public bool AtualizarCurso(int idcurso, string nomedocurso, string turma, string tipo, string status)
        {
            bool retornodao = false;
            CursoDTO cursodto = new CursoDTO(idcurso,nomedocurso, turma, tipo, status);
            CursoDAO cursodao = new CursoDAO();
            retornodao = cursodao.Atualizar(cursodto);
            return retornodao;
        }

        public bool DeletarCurso(int idcurso)
        {
            bool retornodao = false;
            CursoDAO cursodao = new CursoDAO();
            retornodao = cursodao.Apagar(idcurso);
            return retornodao;
        }
    }
}
