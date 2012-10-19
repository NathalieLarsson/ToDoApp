using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using ToDoApp.Domain.Model;

namespace ToDoApp.Domain.Repository
{
	public interface IUserRepository
	{
		IQueryable<User> GetAll();
		User GetSingle(int fooId);
		IQueryable<User> FindBy(Expression<Func<User, bool>> predicate);
		void Add(User entity);
		void Delete(User entity);
		void Edit(User entity);
		void Save();
	}

	public class UserRepository : IUserRepository
	{
		private readonly Context ctx = new Context();

		public IQueryable<User> GetAll()
		{
			IQueryable<User> query = ctx.Users;
			return query;
		}

		public User GetSingle(int Id)
		{
			var query = this.GetAll().FirstOrDefault(x => x.Id == Id);
			return query;
		}

		public IQueryable<User> FindBy(Expression<Func<User, bool>> predicate)
		{
			return ctx.Users.Where(predicate);
		}

		public void Add(User entity)
		{

			ctx.Users.Add(entity);
		}

		public void Delete(User entity)
		{

			ctx.Users.Remove(entity);
		}

		public void Edit(User entity)
		{

			ctx.Entry<User>(entity).State = System.Data.EntityState.Modified;
		}

		public void Save()
		{

			ctx.SaveChanges();
		}
	}
}