using System;
using Domain.Models;

namespace Service.Services
{
	public class AccountService
	{
		public bool Login(string username, string password)
		{
			var dbUsers = GetUsers();

			foreach (var user in dbUsers)
			{
				if (user.Username==username && user.Password ==password)
				{
					return true;
				}
			}
			return false;
		}


		private User[] GetUsers()
		{
			User[] users =
		    {
				new User
			    {
					Id=1,
					Username="ismayil55",
					Password ="ismayil123"
				},

				new User
                {
                    Id = 2,
                    Username = "xeyyam55",
                    Password = "xeyyam123"
                },
                new User
                {
                    Id=3,
                    Username="pervin55",
                    Password ="pervin123"
                }

            };

			return users;
		}
	}
}

