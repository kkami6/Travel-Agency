using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace TestingLayer
{

    [TestFixture]
    internal class ExcursionsContextTests
    {
        static ExcursionsContext excursionsContext;

        static ExcursionsContextTests()
        {
            excursionsContext = new ExcursionsContext(TestManager.dbContext);
        }

        //[Test]

        //public void CreateExcursion()
        //{
        //    Excursion newExcursion = new Excursion(1, 1, 1730, 5,);
        //}
    }
}
