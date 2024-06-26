﻿using Microsoft.EntityFrameworkCore;
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

		public void Add(in Client sender)
		{
			 _context.Add(sender).State = EntityState.Added;
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
			if(client is { })
			{
				_context.Users.Remove(client);
				return true;
			}
			return false;
		}

		public int Save(in Client sender)
		{
			return _context.SaveChanges();
		}

		public void Update(in Client sender)
		{
			_context.Entry(sender).State = EntityState.Modified;
		}
	}
}
