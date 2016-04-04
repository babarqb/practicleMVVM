using System.Collections.Generic;
using PracticleMVVM.DAL;
using PracticleMVVM.Models;

namespace PracticleMVVM.Services
{
    public class CoffeeDataService : ICoffeeDataService
    {
        readonly ICoffeeRepository _repository = new CoffeeRepository();
        public CoffeeDataService()
        {
            
        }

        public Coffee GetCoffeeDetail(int coffeeId)
        {
            return _repository.GetCoffeeById(coffeeId);
        }

        public List<Coffee> GetAllCoffees()
        {
            return _repository.GetCoffees();
        }

        public void UpdateCoffee(Coffee coffee)
        {
            _repository.UpdateCoffee(coffee);
        }

        public void DeleteCoffee(Coffee coffee)
        {
            _repository.DeleteCoffee(coffee);
        }
    }
}