using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory_test
{
    public class CarStoreTest
    {
        [Fact]
        public void AddCar_AddToyota_ListContainObject()
        {
            //ARRANGE
            CarStore carStore = new CarStore();

            Toyota toyota = new Toyota();

            BMW bmw = new BMW();

            //ACT
            carStore.AddCar(toyota);

            //Assert collection
            Assert.NotEmpty(carStore.cars);
            Assert.Contains<Car>(toyota, carStore.cars);

            //Assert.Contains<Car>(carStore.cars, c => c.drivingMode == DrivingMode.Forward);

           // Assert.DoesNotContain<Car>(carStore.cars, c => c.velocity == 10);

        }
    }
}
