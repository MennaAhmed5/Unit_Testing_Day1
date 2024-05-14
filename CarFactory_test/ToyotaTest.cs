using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory_test
{
    public class ToyotaTest
    {
        //reference assert

        [Fact]
        public void GetMyCar_AskForReference_Same()
        {
            //ARRANG
            Toyota toyota = new Toyota();
            Toyota t1 = new Toyota();

            //FACT
            Car res = toyota.GetMyCar();

            //ASSERT
            Assert.Same(res, toyota);
            Assert.NotSame(res, t1);
        }
    }
}
