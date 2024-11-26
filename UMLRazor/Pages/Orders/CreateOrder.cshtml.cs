using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using PizzaLibrary.Services;

namespace UMLRazor.Pages.Orders
{
    public class CreateOrderModel : PageModel
    {
        private ICustomerRepository _cRepo;
        private IMenuItemRepository _mRepo;
        private IShoppingBasket _shoppingBasket;

        #region Properties
        public string MessageCustomer { get; set; }
        public string MessageOrder { get; set; }
        [BindProperty]
        public bool Delivery { get; set; }
        [BindProperty]
        public string SearchCustomerMobile { get; set; }
        public Customer TheCustomer { get; set; }
        [BindProperty]
        public int ChosenMenuItem { get; set; }
        public List<SelectListItem> MenuItemSelectList { get; set; }
        [BindProperty]
        public int Amount { get; set; }
        [BindProperty]
        public string Comment { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        [BindProperty]
        public int SearchOrderLineById { get; set; }
        #endregion

        #region Methods
        public CreateOrderModel(ICustomerRepository customerRepository,
                                IMenuItemRepository menuItemRepository,
                                IShoppingBasket shoppingBasket)
        {
            _cRepo = customerRepository;
            _mRepo = menuItemRepository;
            _shoppingBasket = shoppingBasket;
            OrderLines = _shoppingBasket.GetAll();
            TheCustomer = _shoppingBasket.Customer;
            createMenuSelectList();
        }

        private void createMenuSelectList() // small first letter for private methods
        {
            MenuItemSelectList = new List<SelectListItem>();
            MenuItemSelectList.Add(new SelectListItem("Select an item", "-1"));
            foreach (MenuItem item in _mRepo.GetAll())
            {
                SelectListItem sli = new SelectListItem(item.Name, item.No.ToString());
                MenuItemSelectList.Add(sli);
            }
        }

        public void OnGet()
        {
        }
        public void OnPostCustomer()
        {
            TheCustomer = _cRepo.GetCustomerByMobile(SearchCustomerMobile);
            _shoppingBasket.Customer = TheCustomer;
            if (TheCustomer == null)
            {
                MessageCustomer = "404: Customer not found";
            }
        }
        public void OnPostAddToOrder()
        {
            if (Amount > 0)
            {
                MenuItem menuItemToOrder = _mRepo.GetMenuItemByNo(ChosenMenuItem);
                if (menuItemToOrder != null)
                {
                    OrderLine ol = new OrderLine(Amount, menuItemToOrder, Comment);
                    _shoppingBasket.AddOrderLine(ol);
                }
            }
        }
        public IActionResult OnPostDelete()
        {
            _shoppingBasket.DeleteOrderLine(SearchOrderLineById);
            return Page();
        }

        public IActionResult OnPostCreateOrder()
        {
            if (_shoppingBasket.Customer == null || _shoppingBasket.Count == 0)
            {
                MessageOrder = "Error: Customer is not selected or there is no item in your cart";
                return Page();
            }
            return RedirectToPage("ShowOrder");
            //should save and print customer info, orderlines, total price (reciept) over to ShowOrder
        }
        #endregion
    }
}
