using SmartWorkout.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.IRepository
{
	internal interface IClientRepository
	{
			Client GetClient(int clientId);
			ICollection<Client> getAllClients();
			Client AddClient(Client newClient);
			void UpdateClient(Client client);
			bool ClientExist(int clientId);

			void DeleteClient(Client client);
			void Save();
		}
}
