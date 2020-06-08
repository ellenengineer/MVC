﻿using System;
using System.Collections.Generic;

namespace MVC.Models
{
    public partial class Itens
    {
        public int NumPed { get; set; }
        public int CodProd { get; set; }
        public int QtdVend { get; set; }
        public decimal ValVend { get; set; }

        public virtual Produto CodProdNavigation { get; set; }
        public virtual Pedido NumPedNavigation { get; set; }
    }
}
