using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory_test
{
    public class CarTest
    {
        [Fact]
        public void Accelerate_Velocity15_Range20to30()
        {
            //Arrang 
            BMW bmw = new BMW() { velocity = 15 };
            Toyota toyota= new Toyota() { velocity = 15 };
            //ACT
            bmw.Accelerate();
            toyota.Accelerate();

            //ASSERT
            Assert.InRange(bmw.velocity, 20, 30);
            Assert.InRange(toyota.velocity, 20, 30);
        }
    }
}
