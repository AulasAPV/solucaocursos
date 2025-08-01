using ProjetoCursos.Model.DTO;
using ProjetoCursos.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AtualizarCurso()
        {

        }

        public void DeletarCurso()
        {

        }
    }
}
