using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_Automation_System_Commercial.MODEL
{
    class Cargo
    {
        private int id_cargo;
        private string descricao;
        private double teto_minimo;
        private double teto_max;

        public int Id_cargo { get => id_cargo; set => id_cargo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Teto_minimo { get => teto_minimo; set => teto_minimo = value; }
        public double Teto_max { get => teto_max; set => teto_max = value; }
    }
}
