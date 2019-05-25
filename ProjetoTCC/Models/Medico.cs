﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class Medico
    {
        [DisplayName("Código do Médico")]
        public int COD_MED { get; set; }

        [DisplayName("Nome do Médico")]
        public string NOME_MED { get; set; }

        [DisplayName("Telefone do Médico")]
        public int TEL_MED { get; set; }

        [DisplayName("Celular do Médico")]
        public int CEL_MED { get; set; }

        [DisplayName("Email do Médico")]
        public string EMAIL_MED { get; set; }

        [DisplayName("CPF do Médico")]
        public int CPF_MED { get; set; }

        [DisplayName("RG do Médico")]
        public int RG_MED { get; set; }

        [DisplayName("CRM do Médico")]
        public string CRM_MED { get; set; }

        [DisplayName("Validade do CRM")]
        public DateTime VALIDADE_CRM { get; set; }

        [DisplayName("Sexo do Médico")]
        public string SEXO_MED { get; set; }

        [DisplayName("Especialidade do Médico")]
        public int cod_espec { get; set; }
    }
}
