using System;
using System.Linq;
using BLL.Interface.Entities;
using BLL.Interface.Interfaces;
using DependencyResolver;
using Ninject;
using DAL.Interface;

namespace ConsolePL
{
    class Program
    {
        private static readonly IKernel resolver;

        static Program()
        {
            resolver = new StandardKernel();
            resolver.ConfigurateResolver();
        }

        static void Main(string[] args)
        {
            DAL.Interface.Interfaces.IRepository<DAL.Interface.DTO.BankAccount> rep = new DAL.ADO.NET.AccountRepository();
            IService<BLL.Interface.Entities.BankAccount> service = new BLL.ServiceImplementation.StandartBankAccountService(rep);
            //DAL.Interface.Interfaces.IRepository<DAL.Interface.DTO.BankAccount> rep = resolver.Get<DAL.Interface.Interfaces.IRepository<DAL.Interface.DTO.BankAccount>>();
            //IService<BankAccount> service = resolver.Get<IService<BankAccount>>();
            //IAccountNumberCreateService creator = resolver.Get<IAccountNumberCreateService>();

            //service.AddBankAccount(new BankAccount(1, "test", "test", CardStatusEnum.Standart));
            //service.AddBankAccount(new BankAccount(1, "test", "test", CardStatusEnum.Gold));
            //service.AddBankAccount(new BankAccount(1, "test", "test", CardStatusEnum.Platinum));

            //var creditNumbers = service.GetAll().ToList();
            //foreach (var t in creditNumbers)
            //{
            //    service.Deposit(t.CardID, 100);
            //}

            //foreach (var item in service.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var t in creditNumbers)
            //{
            //    service.Withdraw(t.CardID, 10);
            //}

            foreach (var item in service.GetAll())
            {
                Console.WriteLine(item);
            }

            service.DeleteBankAccount(1);
            service.DeleteBankAccount(2);
            service.DeleteBankAccount(3);
            service.DeleteBankAccount(4);
            service.DeleteBankAccount(5);
            service.DeleteBankAccount(6);
            service.DeleteBankAccount(10);
            service.DeleteBankAccount(8);
            service.DeleteBankAccount(11);
            service.DeleteBankAccount(12);
            service.DeleteBankAccount(13);
            service.DeleteBankAccount(14);
            service.DeleteBankAccount(15);
            service.DeleteBankAccount(16);

            Console.ReadLine();
        }
    }
}
