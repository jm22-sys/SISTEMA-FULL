using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {
        public int CdPessoa { get; set; }
        public string NmPessoa { get; set; }
        public string NrCPF { get; set; }
        public DateTime DtNascimento { get; set; }
        public char DsEstadoCivil { get; set; }
        public char DsSexo { get; set; }
        public string DsEmail { get; set; }
        public string NrTelefone { get; set; }
        public bool BtRecebeSMS { get; set; }
        public bool BtRecebeEmail { get; set; }

    }
}
