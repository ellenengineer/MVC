﻿using System;
using System.Collections.Generic;

namespace MVC.Models
{
    public partial class Conjuge
    {
        public int CodCli { get; set; }
        public string NomeConj { get; set; }
        public decimal RendaConj { get; set; }
        public string SexoConj { get; set; }

        public virtual Cliente CodCliNavigation { get; set; }
    }
}
