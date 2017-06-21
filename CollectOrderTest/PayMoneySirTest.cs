using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERAShop;

using System.IO;

namespace CollectOrderTest {
    [TestClass]
    public class PayMoneySirTest {

        [TestMethod]
        public void CostCalcValid () {

            StoreWarehouse storage = new StoreWarehouse ();
            OrderCalc calc = new OrderCalc ();

            storage.producer = ProductDealers.Ikea;
            storage.delivery = Deliveries.Cargo;
            calc.Distance = Route.Distance (Routes.Chisinau);
            calc.Quantity = 1;

            int expected = 1830;

            int actual = calc.Cost;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod]
        public void DepartmentValid () {

            StoreWarehouse storage = new StoreWarehouse ();

            storage.type = Types.FastDelivery;
            storage.delivery = Deliveries.Cargo;
            storage.ProductName = "Dress";

            string expected = "Dolphine";
            string actual = storage.Department;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod]
        public void SectionValid () {

            StoreWarehouse storage = new StoreWarehouse ();

            storage.type = Types.FastDelivery;
            storage.delivery = Deliveries.Cargo;
            storage.ProductName = "Dress";

            int expected = 1;
            int actual = storage.Section;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod]
        public void FullNameTestValid () {
            Employee employee = new Employee ();
            employee.FirstName = "Elena";
            employee.LastName = "Riabikina";

            string expected = "Elena Riabikina";

            string actual = employee.FullName;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty () {

            Employee employee = new Employee ();
            employee.LastName = "Riabikina";

            string expected = "Riabikina";

            string actual = employee.FullName;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty () {

            Employee employee = new Employee ();
            employee.FirstName = "Elena";

            string expected = "Elena";

            string actual = employee.FullName;

            Assert.AreEqual (expected, actual);
        }
        
    }
}
