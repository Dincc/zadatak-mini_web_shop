﻿using System.Collections.Generic;

namespace Zadatak.MiniWebShop.Model.Narudzbe
{
    public class NacinPlacanja
    {
        public NacinPlacanja()
        {
            Narudzbas = new HashSet<Narudzba>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Narudzba> Narudzbas { get; set; }
    }
}