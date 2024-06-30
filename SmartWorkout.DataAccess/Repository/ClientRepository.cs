using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SmartWorkout.DataAccess.Entities;
using SmartWorkout.DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Repository
{
	internal class ClientRepository : IClientRepository
	{
		private readonly SmartWorkoutContext _context;

		public ClientRepository(SmartWorkoutContext context)
		{
			_context = context;
		}

		public Client AddClient(Client newClient)
		{
			return _context.Add(newClient).Entity;
		}

		public bool ClientExist(int clientId)
		{
			return _context.Exercises.Any(c=>c.Id == clientId);
		}

		public void DeleteClient(Client client)
		{
			_context.Remove(client);
		
			Save();
		}

		public ICollection<Client> getAllClients()
		{
			return _context.Users.ToList();
		}

		public Client GetClient(int clientId)
		{
			return _context.Users.Where(c => c.Id == clientId).FirstOrDefault();
		}

	

		public void Save()
		{
			_context.SaveChanges();

		}

		public void UpdateClient(Client client)
		{
			_context.Update(client);
			 Save();
		}
	}
}
