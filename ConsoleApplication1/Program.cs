using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			var UserRep = new ToDoApp.Domain.Repository.UserRepository();

			var nyUser = new ToDoApp.Domain.Model.User() {
				Id = 1
			};

			UserRep.Add(nyUser);
			UserRep.Save();

			Console.WriteLine("Användare sparad till databas");
		}
	}
}
