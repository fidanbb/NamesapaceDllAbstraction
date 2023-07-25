using System;
using Service.Helpers;
using Service.Services;

namespace ClassWrk_DLL_Abstraction.Controllers
{
	public class AccountCountroller
	{
		AccountService _accountService;

		public AccountCountroller()
		{
			_accountService = new();
		}

		public void Login()
		{
			Console.WriteLine("Username:");
			Username:  string username = Console.ReadLine();

			Console.WriteLine("Password");
			string password = Console.ReadLine();

			bool isLogin = _accountService.Login(username,password);

			if (isLogin)
			{
				Console.WriteLine(AccountMessage.LoginSuccess);
			}
			else
			{
				Console.WriteLine(AccountMessage.LoginFailed);
				goto Username;
			}
		}
	}
}

