using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory_test
{
    public class BMWTest
    {
        //1 boolean
        [Fact]
        public void IsStopped_Velocity0_true()
        {
            //ARRANGE 
            BMW bmw = new BMW();
            bmw.velocity = 0;

            //ACT
            bool result = bmw.IsStopped();

            //ASSERT
            Assert.True(result);
           
        }

        //2 numeric assert

        [Fact]
        public void IncreaseVelocity_VelocityEqual20Add20()
        {
            //ARRANG

            BMW bmw = new BMW();
            bmw.velocity = 20;

            double AddedVelocity = 20;
            //ACT

            bmw.IncreaseVelocity(AddedVelocity);

            //ASSERT

            Assert.Equal(40, bmw.velocity);
        }

        //5 string
        [Fact]
        public void GetDirection_DirectionBackward_Backward()
        {
            //ARRANGE
            BMW bmw = new BMW() { drivingMode = DrivingMode.Backward };

            //ACT
            String res = bmw.GetDirection();

            Assert.Equal("Backward", res);
            Assert.StartsWith("Ba", res);
            Assert.EndsWith("d", res);
            Assert.Contains("wa", res);
            Assert.Matches("B[a-z]{8}",res);


        }
    }
}
