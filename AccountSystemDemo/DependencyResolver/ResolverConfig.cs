using BLL.Interface.Entities;
using BLL.Interface.Interfaces;
using BLL.ServiceImplementation;
using BLL.Mappers;
using DAL.Interface.Interfaces;
using DAL.Repositories;
using Ninject;
#pragma warning disable CS0234 // Тип или имя пространства имен "ADO" не существует в пространстве имен "DAL" (возможно, отсутствует ссылка на сборку).
using DAL.ADO.NET;
#pragma warning restore CS0234 // Тип или имя пространства имен "ADO" не существует в пространстве имен "DAL" (возможно, отсутствует ссылка на сборку).

namespace DependencyResolver
{
    public static class ResolverConfig
    {
        public static void ConfigurateResolver(this IKernel kernel)
        {
            //kernel.Bind<IRepository<DAL.Interface.DTO.BankAccount>>().To<BinaryRepository>().WithConstructorArgument("test.bin");
            kernel.Bind<IRepository<DAL.Interface.DTO.BankAccount>>().To<AccountRepository>();
            kernel.Bind<IService<BankAccount>>().To<StandartBankAccountService>();
            kernel.Bind<IConverter<BankAccount, DAL.Interface.DTO.BankAccount>>().To<ConvertBLLBankAccountToDALBankAccount>();
            kernel.Bind<IConverter<DAL.Interface.DTO.BankAccount, BankAccount>>().To<ConvertDALBankAccountToBLLBankAccount>();

            //kernel.Bind<IRepository>().To<FakeRepository>();
            //kernel.Bind<IAccountNumberCreateService>().To<AccountNumberCreator>().InSingletonScope();
            //kernel.Bind<IApplicationSettings>().To<ApplicationSettings>();
        }
    }
}
