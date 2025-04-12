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

        [Test]

        public void CreateExcursion()
        {
            Excursion newExcursion = new Excursion(1, 1, 1730, DateTime.Now, DateTime.Now);
            
            excursionsContext.Create(newExcursion);

            Excursion excursion = TestManager.dbContext.Excursions.Last();
            Assert.That(newExcursion.ExcursionId, Is.EqualTo(excursion.ExcursionId), "The Ctreate() method does not work. :(");
        }

        [Test]
        public void ReadExcursion()
        {
            Excursion newExcursion = new Excursion(1, 1, 1730, DateTime.Now, DateTime.Now);
            excursionsContext.Create(newExcursion);

            Excursion excursion = excursionsContext.Read(1);

            Assert.That(newExcursion.ExcursionId == excursion.ExcursionId || newExcursion.Price == excursion.Price,
                "The Read() method does not work! :(");
        }

        [Test]
        public void ReadAllExcursions()
        {
            int excursionsBefore = TestManager.dbContext.Excursions.Count();

            int excursionsAfter = excursionsContext.ReadAll().Count;

            Assert.That(excursionsBefore == excursionsAfter, "The ReadAll() method does not work :(");
        }

        [Test]
        public void UpdateExcursion()
        {
            Excursion newExcursion = new Excursion(1, 1, 1730, DateTime.Now, DateTime.Now);
            excursionsContext.Create(newExcursion);

            Excursion lastExcursion = excursionsContext.ReadAll().Last();
            lastExcursion.Price = 2050;

            excursionsContext.Update(lastExcursion);

            Assert.That(excursionsContext.Read(lastExcursion.ExcursionId).Price == 2050, "The update() method does not work! :(");
        }

        [Test]

        public void DeleteExcursion()
        {
            Excursion newExcursion = new Excursion(1, 1, 1730, DateTime.Now, DateTime.Now);
            excursionsContext.Create(newExcursion);

            List<Excursion> excursions = excursionsContext.ReadAll();
            int excursionsBefore = excursions.Count();
            Excursion lastExcursion = excursions.Last();

            excursionsContext.Delete(lastExcursion.ExcursionId);

            int excursionsAfter = excursionsContext.ReadAll().Count();

            Assert.That(excursionsBefore == excursionsAfter + 1, "The Delete() method does not work! :(");
        }
    }
}
