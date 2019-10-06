using BLL.Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            DAL.Interface.Interfaces.IRepository<DAL.Interface.DTO.BankAccount> rep = new DAL.ADO.NET.AccountRepository();
            IService<BLL.Interface.Entities.BankAccount> service = new BLL.ServiceImplementation.StandartBankAccountService(rep);
            List<Models.BankAccountViewModel> listOfAccounts = new List<Models.BankAccountViewModel>();

            foreach (var c in service.GetAll())
            {
                listOfAccounts.Add(new Models.BankAccountViewModel { CardID = c.CardID, Amount = c.Amount, BonusAmount = c.BonusAmount, CardStatus = (Models.CardStatusEnum)c.CardStatus, LastName = c.LastName, Name = c.Name});
            }

            return View(listOfAccounts);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.BankAccountViewModel model)
        {
            DAL.Interface.Interfaces.IRepository<DAL.Interface.DTO.BankAccount> rep = new DAL.ADO.NET.AccountRepository();
            IService<BLL.Interface.Entities.BankAccount> service = new BLL.ServiceImplementation.StandartBankAccountService(rep);

            service.AddBankAccount(new BLL.Interface.Entities.BankAccount(1, model.Name, model.LastName, (BLL.Interface.Entities.CardStatusEnum)model.CardStatus));

            return RedirectToAction("Index");
        }

    }
}