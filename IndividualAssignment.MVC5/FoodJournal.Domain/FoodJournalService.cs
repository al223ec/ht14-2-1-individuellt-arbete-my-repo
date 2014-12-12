using FoodJournal.Domain.DAL;
using FoodJournal.Domain.Webservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodJournal.Domain
{
    public class FoodJournalService : IFoodJournalService
    {
        private IUnitOfWork _unitOfWork;
        private IFoodstuffWebservice _webservice;

        public FoodJournalService()
            : this(new UnitOfWork(), new FoodstuffWebservice())
        {
            // Empty!
        }

        public FoodJournalService(IUnitOfWork unitOfWork, IFoodstuffWebservice webservice)
        {
            _unitOfWork = unitOfWork;
            _webservice = webservice;
        }

        public IEnumerable<string> GetFoodstuffNames(string term)
        {
            return _unitOfWork.FoodstuffRepository
                .Get(u => u.Name.Contains(term))
                .Select(u => u.Name)
                .OrderBy(s => s)
                .ToList();
        }
        public IEnumerable<string> GetFoodstuffNames()
        {
            return _unitOfWork.FoodstuffRepository
                .GetAll()
                .Select(u => u.Name)
                .OrderBy(s => s)
                .ToList();
        }

        public IEnumerable<Foodstuff> GetFoodstuff()
        {
            return _unitOfWork.FoodstuffRepository.GetAll(); 
        }

        /// <summary>
        /// Kommer genomföra en request till Matapi.se för att hämta all data som tillhör den specifika foodstuffen. 
        /// Har denna data redan hämtas läses den ut i samband med att förfrågan sker mot databasen för att hämta foodstuff
        /// </summary>
        /// <param name="foodstuff"></param>
        /// <returns>NutrientValue</returns>
        public NutrientValues GetNutrientValues(Foodstuff foodstuff)
        {
            if (foodstuff.NutrientValues == null)
            { 
                NutrientValues nutrientValues = _webservice.GetNutrientValues(foodstuff.Number);
                foodstuff.NutrientValues = nutrientValues;
                _unitOfWork.NutrientValuesRepository.Add(nutrientValues);
                _unitOfWork.Save();

                return nutrientValues;
            }
            return foodstuff.NutrientValues;
        }

        public void SaveMeal(Meal meal)
        {
            throw new NotImplementedException();
        }

        #region IDisposable

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _unitOfWork.Dispose();
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
