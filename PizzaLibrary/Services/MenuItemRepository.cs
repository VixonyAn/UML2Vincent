using PizzaLibrary.Data;
using PizzaLibrary.Exceptions;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PizzaLibrary.Services
{
    public class MenuItemRepository : IMenuItemRepository
    {
        #region Instance Fields
        private List<MenuItem> _menuItemList;
        private List<MenuItem> _menuItemListMinPrice;
        #endregion

        #region Property
        public int Count { get { return _menuItemList.Count; } }
        // Returns the number of objects in menuitems
        #endregion

        #region Constructor
        public MenuItemRepository()
        { // Constructor done
            _menuItemList = MockData.MenuItemData;
        }
        #endregion

        #region Methods
        public void AddMenuItem(MenuItem menuItem)
        { // Add method approved
            _menuItemList.Add(menuItem);
        }

        public List<MenuItem> GetAll()
        { // Return a list without printing anything
            return _menuItemList;
        }

        public MenuItem GetMenuItemByNo(int no)
        { // Approved
            foreach (MenuItem menuItem in _menuItemList)
            {
                if (no == menuItem.No)
                {
                    return menuItem;
                }
            }
            return null; // Ignore this, it's okay
        }

        public void PrintAllMenuItems()
        { // cw, like a tostring?
            /* Don't use this, the output is not controlled
            Console.WriteLine(_menuItemList); */
            // Approved below
            foreach (MenuItem menuItem in _menuItemList)
            {
                Console.WriteLine(menuItem.ToString());
            }
        }

        public void RemoveMenuItem(int no)
        { // Approved and tested
            // the simplest method which reuses a previous function
            MenuItem foundItem = GetMenuItemByNo(no);
            _menuItemList.Remove(foundItem);
        }

        public List<MenuItem> MinPriceList() // just a filterer, not a printer!!
        { // Approved -  list all items over 50 dkk
            List<MenuItem> minPriced = new List<MenuItem>(); // local instance
            foreach (MenuItem menuItem in _menuItemList)
            {
                if (50 <= menuItem.Price) // doesn't need a value specified
                { // if true, add to the list
                    minPriced.Add(menuItem);
                }
            }
            return minPriced;
        }
        
        public MenuItem MostExpensivePizza()
        { // According to GRASP this file is the Expert,
          // which should handle finding the most expensive pizza
            if (_menuItemList == null || _menuItemList.Count == 0)
            {
                return null;
            }
            else
            {
                MenuItem mostExpensivePizza = new MenuItem();
                mostExpensivePizza.Price = 0;
                foreach (MenuItem menuItem in _menuItemList)
                {
                    if (menuItem.TheMenuType == MenuType.PIZZECLASSSICHE
                        || menuItem.TheMenuType == MenuType.PIZZESPECIALI 
                        && menuItem.Price > mostExpensivePizza.Price)
                    {
                        mostExpensivePizza = menuItem;
                    }
                }
                return mostExpensivePizza;
            }
        }

        //public MenuItem PrintAllMenuItemType(MenuType type)
        //{
        //    if (type != MenuType.SANDWICHES || MenuType.BRUCHETTA_CROSTINO || MenuType.SALATER || MenuType.PIZZECLASSSICHE || MenuType.PIZZESPECIALI || MenuType.PASTAALFORNO || MenuType.TILBEHØR)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        #endregion
    }
}
