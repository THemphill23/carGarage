using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> Cars = new List<Car>();

        public void AddCar(string make, string model)
        {
            Car car = new Car(make, model);
        
            Cars.Add(car);
        }
    }
}
