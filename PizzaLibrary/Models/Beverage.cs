using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Models
{
    public class Beverage : MenuItem
    {
        public bool Alcohol { get; set; }
        public Beverage(string name, double price, string description, MenuType menuType, bool alcohol) : base(name, price, description, menuType)
        {
            Alcohol = alcohol;
        }
        public override string ToString()
        {
            return $"ID: {No}\n" +
                   $"Navn: {Name}\n" +
                   $"Pris: {Price}\n" +
                   $"Beskrivelse: {Description}\n" +
                   $"Menu Type: {TheMenuType}\n" +
                   $"Contains alcohol: {Alcohol}\n";
        }
    }
}
