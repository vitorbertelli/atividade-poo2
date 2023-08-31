using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade.Classes
{
    internal class Disciplina
    {
        private string nomeDisciplina;
        private int cargaHoraria;

        public int CargaHoraria { get; }

        public Disciplina(string nomeDisciplina, int cargaHoraria)
        {
            this.nomeDisciplina = nomeDisciplina;
            this.cargaHoraria = cargaHoraria;
        }
    }
}
