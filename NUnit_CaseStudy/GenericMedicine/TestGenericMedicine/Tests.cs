using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMedicine;
using NUnit.Framework;

namespace TestGenericMedicine
{
    [TestFixture]
    public class Tests
    {
        Program program = new Program();
        [SetUp]
        public void Setup()
        {
        }
        //Medicine medicine = new Medicine();
        [Test]
        [TestCase("Dolo", "Dolo650", "Dolo","02-02-2030", 50, ExpectedResult = "Dolo,Dolo650,Dolo,02-02-2030")]
        //Medicine name cannot be empty
       // [TestCase("", "Sinus77", "Paracetamol", "02-02-2030", 50, ExpectedResult = ",Sinus77,Paracetamol,02-02-2030")]
        //Generic medicine cannot be empty
        //[TestCase("Dolo", "", "Dolo", "02-02-2030", 50, ExpectedResult = "Dolo,,Dolo,02-02-2030")]
        //Medicine Composition camnnot be empty
        //[TestCase("Vicks", "Vicks500", "", "02-02-2030", 50, ExpectedResult = "Vicks,Vicks500,,02-02-2030")]
        //Incorrect expiry date
        //[TestCase("Glutone", "Glutone1000", "Vitamin-C", "02-02-2015", 50, ExpectedResult = "Glutone,Glutone1000,Vitamin-C,02-02-2015")]
        public string TestMedicine(string name, string genericMedicineName, string composition, string expirydate, double pricePerStrip)
        {
            DateTime temp = DateTime.Parse(expirydate);
            Medicine medicine = program.CreateMedicineDetail(name,genericMedicineName, composition, temp, pricePerStrip);
            string result = string.Format("{0},{1},{2},{3}", medicine.Name, medicine.GenericMedicineName,medicine.Composition, medicine.ExpiryDate.ToShortDateString(), medicine.PricePerStrip);

            return result;
        }
        //All correct
        [TestCase(5, "2023-02-01", "Mumbai", ExpectedResult = "5,01-02-2023,Mumbai")]
        //Incorrect Strip count
        [TestCase(0, "2023-02-01", "Mumbai", ExpectedResult = "0,01-02-2023,Mumbai")]
        //Incorrect Launch date
        [TestCase(5, "2015-02-01", "Mumbai", ExpectedResult = "5,01-02-2015,Mumbai")]
        //Launch date greater than expiry date
        [TestCase(5, "2040-02-01", "Mumbai", ExpectedResult = "5,01-02-2040,Mumbai")]
        //Incorrect Retailer address
        [TestCase(5, "2023-02-01", "", ExpectedResult = "5,01-02-2023,")]
        public string TestCartonDetails(int medicineStripCount, string launchDate, string retailerAddress)

        {
            DateTime datetime = DateTime.Parse(launchDate);
            var medicine = new Medicine()
            {
                Name = "Dolo",
                GenericMedicineName = "Dolo650",
                Composition = "Dolo",
                ExpiryDate = DateTime.Parse("02-02-2030"),
                PricePerStrip = 50
            };
            CartonDetail carton = program.CreateCartonDetail(medicineStripCount, datetime, retailerAddress, medicine);
            string result = string.Format("{0},{1},{2}", carton.MedicineStripCount, carton.LaunchDate.ToShortDateString(), carton.RetailerAddress.Trim());
            
            return result;
        }
    }
}
