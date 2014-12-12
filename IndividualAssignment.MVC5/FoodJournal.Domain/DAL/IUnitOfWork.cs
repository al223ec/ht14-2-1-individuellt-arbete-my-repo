using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodJournal.Domain.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Foodstuff> FoodstuffRepository { get; }

        void Save();
    }
}
