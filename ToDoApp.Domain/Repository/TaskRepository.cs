using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using ToDoApp.Domain.Model;

namespace ToDoApp.Domain.Repository
{
	public interface ITaskRepository
	{
		IQueryable<Task> GetAll();
		Task GetSingle(int fooId);
		IQueryable<Task> FindBy(Expression<Func<Task, bool>> predicate);
		void Add(Task entity);
		void Delete(Task entity);
		void Edit(Task entity);
		void Save();
	}

	public class TaskRepository : ITaskRepository
	{
		private readonly Context ctx = new Context();

		public IQueryable<Task> GetAll()
		{
			IQueryable<Task> query = ctx.Tasks;
			return query;
		}

		public Task GetSingle(int Id)
		{
			var query = this.GetAll().FirstOrDefault(x => x.Id == Id);
			return query;
		}

		public IQueryable<Task> FindBy(Expression<Func<Task, bool>> predicate)
		{
			return ctx.Tasks.Where(predicate);
		}

		public void Add(Task entity)
		{

			ctx.Tasks.Add(entity);
		}

		public void Delete(Task entity)
		{

			ctx.Tasks.Remove(entity);
		}

		public void Edit(Task entity)
		{

			ctx.Entry<Task>(entity).State = System.Data.EntityState.Modified;
		}

		public void Save()
		{

			ctx.SaveChanges();
		}
	}
}