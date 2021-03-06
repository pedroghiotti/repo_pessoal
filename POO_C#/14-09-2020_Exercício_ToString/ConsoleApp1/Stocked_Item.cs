﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Estoque
{
    class Stocked_Item
    {
        internal string product;
        internal int amountInStock;
        internal double price;

        // Methods //
        internal double CalculateTotalValue()
        {
            return price * amountInStock;
        }
        internal void AddToStock(int amount)
        {
            amountInStock += amount;
        }
        internal void SubtractFromStock(int amount)
        {
            amountInStock -= amount;
        }
        public override string ToString()
        {
            return "Dados do produto: " + product + ", R$" + price + ", quantidade em estoque: " + amountInStock + ", valor total em estoque: " + CalculateTotalValue() +".";
        }
    }
}
