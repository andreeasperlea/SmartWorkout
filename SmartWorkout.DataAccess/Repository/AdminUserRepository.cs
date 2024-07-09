using SmartWorkout.DataAccess.Entities;
using SmartWorkout.DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Repository
{
	public class AdminUserRepository : IGenericRepository<AdminUser>
	{
		private readonly SmartWorkoutContext _context;

		public AdminUserRepository(SmartWorkoutContext context)
		{
			_context = context;
		}
		public void Add(AdminUser adminUser)
		{
			_context.Add(adminUser);
			_context.SaveChanges();
		}

		public IEnumerable<AdminUser> GetAll()
		{
			return _context.AdminUsers.ToList();
		}

		public AdminUser? GetById(int Id)
		{
			return _context.AdminUsers.Find(Id);
		}

		public bool Remove(int Id)
		{
			var adminUser = _context.AdminUsers.Find(Id);
			if (adminUser != null)
			{
				_context.AdminUsers.Remove(adminUser);
				_context.SaveChanges();
				return true;
			}
			return false;
		}


		public void Update(AdminUser adminUser)
		{
			_context.Update(adminUser);
			_context.SaveChanges();
		}
	}
}
