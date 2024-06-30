using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.IRepository
{
	public interface IGenericRepository<T> where T : class
	{
		IEnumerable<T> GetAll();
		T? GetById(int Id);
		bool Remove(int Id);
		int Save(in T sender);

		void Add(in T sender);
		void Update(in T sender);

	}
}
