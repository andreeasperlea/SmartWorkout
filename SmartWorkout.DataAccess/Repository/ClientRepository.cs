using Microsoft.EntityFrameworkCore;
using SmartWorkout.DataAccess.Entities;
using SmartWorkout.DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Repository
{
	public class ClientRepository : IGenericRepository<Client>
	{
		private readonly SmartWorkoutContext _context;

		public ClientRepository(SmartWorkoutContext context)
		{
			_context = context;
		}

		public void Add(Client client)
		{
			_context.Add(client);
			_context.SaveChanges();
		}

		public IEnumerable<Client> GetAll()
		{
			return _context.Users.ToList();
		}

		public Client? GetById(int Id)
		{
			return _context.Users.Find(Id);
		}

		public bool Remove(int Id)
		{
			var client= _context.Users.Find(Id);
			if(client != null)
			{
				_context.Users.Remove(client);
				_context.SaveChanges();
				return true;
			}
			return false;
		}


		public void Update(Client client)
		{
			_context.Update(client);
			_context.SaveChanges();
		}
	}
}
