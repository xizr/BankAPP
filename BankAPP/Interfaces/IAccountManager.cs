using BankAPP.Models;

namespace BankAPP.Interfaces
{
    public interface IAccountManager

    {
        void Register();
        User Login();
    }
}
