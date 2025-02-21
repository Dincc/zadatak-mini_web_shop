﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak.MiniWebShop.Model.Narudzbe;

namespace Zadatak.MiniWebShop.Model.Proizvodi
{
    public class Kosarica
    {
        public Kosarica()
        {

        }
        private List<Proizvod> _items = new List<Proizvod>();
        public IReadOnlyCollection<Proizvod> Items => _items;
        public void AddItem(Proizvod item)
        {
            if (item!=null)
            {
                try
                {
                    if (item.Kolicina == 0)
                    {
                        throw new NotAvailableException();
                    }
                    _items.Add(item);
                }
                catch (Exception)
                {

                    Console.WriteLine("Not available.");
                }
            }
        }
        public void RemoveItem(Proizvod item)
        {
            _items.Remove(item);
        }
        public void RemoveItem(int id)
        {
            _items.Remove(_items.Find(o=> o.Id == id));
        }
    }
}
