using System.Collections.Generic;
using PracticleMVVM.Models;

namespace PracticleMVVM.DAL
{
    public interface ICoffeeRepository
    {
        void DeleteCoffee(Coffee coffee);
        Coffee GetACoffee();
        Coffee GetCoffeeById(int id);
        List<Coffee> GetCoffees();
        void UpdateCoffee(Coffee coffee);
    }
}