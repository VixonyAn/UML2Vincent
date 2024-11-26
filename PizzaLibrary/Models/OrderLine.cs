using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PizzaLibrary.Interfaces;

namespace PizzaLibrary.Models
{
    public class OrderLine : IOrderLine
    { // These are the individual lines of items a person has ordered
        #region Instance Fields
        private int _id;
        private MenuItem _menuItem;
        public static int _counter = 0;
        private List<Accessory> _accessories;
        #endregion

        #region Properties
        public MenuItem MenuItem { get { return _menuItem; } set { _menuItem = value; } }
        public int Amount { get; set; }
        public string Comment { get; set; }
        public int Id { get { return _id; } set { _id = value; } }
        #endregion

        #region Constructors
        public OrderLine(int amount, MenuItem menuItem)
        { // without comments
            Amount = amount;
            MenuItem = menuItem;
        }
        public OrderLine(int amount, MenuItem menuItem, string comment)
        { // with comments
            Amount = amount;
            MenuItem = menuItem;
            Comment = comment;
        }
        #endregion

        #region Methods
        public void AddExtraAccessory(Accessory accessory)
        {
            
        }
        public double SubTotal()
        {
            return MenuItem.Price * Amount;
        }
        // TODO skal vise priserne på items i orderline, f.eks. 1 pizza 79 kr og 2 sodavand 40 kr
        public override string ToString() //amount id name price
        { // orderline is basically menuitem? but add the subtotal. kan også indeholde kommentar?
            return $"{Amount} #{MenuItem.No} {MenuItem.Name}    {SubTotal()} dkk\n{Comment}\n"; 
        }
        #endregion
    }
}
