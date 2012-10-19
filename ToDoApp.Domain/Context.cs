using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoApp.Domain.Model;

namespace ToDoApp.Domain
{
	public class Context : DbContext
	{
		public Context()
			: base(@"Data Source=(localdb)\v11.0;Initial Catalog=ToDoApp;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False") 
		{}
		public DbSet<Task> Tasks { get; set; }
		public DbSet<User> Users { get; set; }
		
	}
}