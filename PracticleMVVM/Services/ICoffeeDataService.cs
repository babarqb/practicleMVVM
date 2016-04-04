using System.Collections.Generic;
using PracticleMVVM.Models;

namespace PracticleMVVM.Services
{
    public interface ICoffeeDataService
    {
        void DeleteCoffee(Coffee coffee);
        List<Coffee> GetAllCoffees();
        Coffee GetCoffeeDetail(int coffeeId);
        void UpdateCoffee(Coffee coffee);
    }
}