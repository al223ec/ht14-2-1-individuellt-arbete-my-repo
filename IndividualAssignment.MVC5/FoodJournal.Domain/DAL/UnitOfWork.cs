using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodJournal.Domain.DAL
{
    class UnitOfWork : IUnitOfWork
    {
        private FoodJournalContext _context = new FoodJournalContext();
        private IRepository<Foodstuff> _foodstuffRepository;
        private IRepository<Meal> _mealRepository;
        private IRepository<NutrientValues> _nutrientValuesRepository;

        public IRepository<Foodstuff> FoodstuffRepository
        {
            get { return _foodstuffRepository ?? (_foodstuffRepository = new RepositoryBase<Foodstuff>(_context)); }
        }

        public IRepository<Meal> MealRepository
        {
            get { return _mealRepository ?? (_mealRepository = new RepositoryBase<Meal>(_context)); }
        }
        public IRepository<NutrientValues> NutrientValuesRepository
        {
            get { return _nutrientValuesRepository ?? (_nutrientValuesRepository = new RepositoryBase<NutrientValues>(_context)); }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        #region IDisposable

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
