using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public Car()

        { 
        
        }
         public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Mustang";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }
        
        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} now driving forward ..");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving forward ..");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park ..");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }

        }

        public bool ChangeGears(bool isChanged)
        {
            throw new NotImplementedException();
        }
    }


}

