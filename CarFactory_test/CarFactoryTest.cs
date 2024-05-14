using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory_test
{
    public class CarFactoryTest
    {
        [Fact]
       public void NewCar_AskForAudi_null()
       {
            //ACT
            Car? res = CarFactory.NewCar(CarTypes.Audi);

            //RESFERENCE
            Assert.Null(res);
       }
        [Fact]
        public void NewCarAskForBMWBMWObject()
        {
            //ARRANGE
            BMW bmw = new BMW();

            //ACT
            Car? res = CarFactory.NewCar(CarTypes.BMW);

            //RESFERENCE
            Assert.NotNull(res);

            //value Equality
            Assert.Equal(bmw, res);
        }

        [Fact]

        public void NewCar_AskForBMW_BMWObject()
        {
            //ARRANGE

            //ACT
            Car? res = CarFactory.NewCar(CarTypes.BMW);
            //TYPE ASSERT
            Assert.IsType<BMW>(res);
            Assert.IsAssignableFrom<Car>(res);

        }

        [Fact]

        public void NewCar_ASKForHonda_Exception()
        {
            //ARRANG

            //ASSERT

            Assert.Throws<NotImplementedException>(() =>
            {
                //ACT
                Car? res = CarFactory.NewCar(CarTypes.Honda);

            });

            Assert.ThrowsAny<Exception>(() =>
            {
                //ACT
                Car? res = CarFactory.NewCar(CarTypes.Honda);
            });


        }

    }
}
