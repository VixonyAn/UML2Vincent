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
            //_menuItemList.Add(menuItem);

            // create new item, check if new items ID is the same as an existing ID, throw error

            for (int i = 0; i < _menuItemList.Count; i++)
            {
                throw new MenuItemNumberExist();
            }


            //foreach (MenuItem mi in _menuItemList)
            //{
            //    if (_menuItemList[]) //look for a Null space in the list
            //    {
            //        AddMenuItem(mi);
            //    }
            //    else
            //    {
            //        throw new MenuItemNumberExist();
            //    }
            //}
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
        #endregion

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
        {
            MenuItem mostExpensive = _menuItemList[0];
            foreach (MenuItem menuItem in _menuItemList)
            {
                if (menuItem.Price > mostExpensive.Price)
                {
                    mostExpensive = menuItem;
                }
            }
            return mostExpensive;
        }
    }
}
