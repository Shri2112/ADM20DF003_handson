using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using  MyFoodSupply;

namespace TestFoodNUnit
{
        [TestFixture]
        public class Tests
        {
            Program program = new Program();

            [SetUp]
            public void Setup()
            {
            }

            [Test]
            //Empty dish name
            //[TestCase("", 2, "2022-02-12", 50, ExpectedResult = ",SideDish,2-12-2022,50")]
            //[TestCase("desert", 1, "2020-02-12", 50, ExpectedResult = "desr, MainDish, 12-02-2020,50")]
            //[TestCase("non-veg", 1, "2020-02-12", 0, ExpectedResult = "non-veg,MainDish, 12-02-2022,0")]
            [TestCase("veg", 2, "2022-02-12", 50, ExpectedResult = "veg,SideDish,12-02-2022,50")]
            public string TestFoodDetails(string name, int dishtype, string expirydate, double price)
            {
                DateTime temp = DateTime.Parse(expirydate);
                FoodDetail foodDetail = program.CreateFoodDetail(name, dishtype, temp, price);
                string result = string.Format("{0},{1},{2},{3}", foodDetail.Name, foodDetail.DishType, foodDetail.ExpiryDate.ToShortDateString(), foodDetail.Price);

                return result;
            }


            //Object
            [TestCase(2, "2021-03-20", "Madhura", 10, ExpectedResult = "Madhura, 3-20-2021, 2, 70")]
            //CountExpection
            [TestCase(0, "2021-03-20", "Madhura", 10, ExpectedResult = "Madhura, 3-20-2021,2,0")]
            //Date Validation
            [TestCase(1, "2020-03-20", "Dhanshri", 30, ExpectedResult = "Dhanshri, 3-20-2020,2,30")]
            public string TestSupplyDetails(int foodItemCount, string requestdate, string sellerName, double packingCharge)
            {
                DateTime datetime = DateTime.Parse(requestdate);
                var foodDetail = new FoodDetail()
                {
                    Name = "Dhanshri",
                    DishType = (FoodDetail.Category)1,
                    ExpiryDate = DateTime.Parse("2020-03-30"),
                    Price = 30
                };
                SupplyDetail supplyDetail = program.CreateSupplyDetail(foodItemCount, datetime, sellerName, packingCharge, foodDetail);
                String result = string.Format("{0},{1},{2},{3}", supplyDetail.SellerName, supplyDetail.RequestDate.ToShortDateString(), supplyDetail.Count, supplyDetail.TotalCost);


                return result;
            }


            [Test]
            [TestCase(2, "2021-03-20", "Madhura", 10)]
            public void TestForNull(int foodItemCount, string requestDate, string sellerName, double packingCharge)
            {
                DateTime datetime = DateTime.Parse(requestDate);
                FoodDetail foodDetail = null;
                SupplyDetail supply = program.CreateSupplyDetail(foodItemCount, datetime, sellerName, packingCharge, foodDetail);
                Assert.IsNull(supply);
            }




        }
    
}
