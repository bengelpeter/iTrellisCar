using iTrellisCarUnitTest.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace iTrellisCarUnitTest
{

    public class CarTestData : IEnumerable<object[]>
    {
        /// <summary>
        /// Random unit test data for ReturnCar
        /// </summary>
        /// <returns></returns>
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "White", "Yes", null, "All", "No", "Yes", "No", "Yes" };
            yield return new object[] { "Black", "Yes", null, "No", "No", "No", "No", "Yes" };
            yield return new object[] { null, "No", null, "Yes", "No", "Yes", "Yes", null };
            yield return new object[] { "White", "Yes", "Yes", "Yes", "No", "Yes", null, "No" };
            yield return new object[] { "Red", "Yes", "Yes", "No", "No", "Yes", null, "Yes" };
            yield return new object[] { "Gray", "Yes", "No", null, "No", "No", null, "No" };
            yield return new object[] { "Silver", "Yes", null, null, "No", "Yes", null, "No" };
            yield return new object[] { "Gray", null, "No", "No", "No", "Yes", null, "Yes" };
            yield return new object[] { "Gray", "Yes", "Yes", "Yes", "Yes", "Yes", "Yes", "No" };
            yield return new object[] { "Red", "No", "No", "No", "No", "No", "No", "No" };
            yield return new object[] { "Red", "No" };
            yield return new object[] { "Silver", "No", "No", "Yes" };
            yield return new object[] { "White", "No", "No", "Yes", "No", "No" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


    public class CarTest
    {

        /// <summary>
        /// Gets the cars from a Json file and returns a list of cars using a Model.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="hasSunroof"></param>
        /// <param name="isFourWheelDrive"></param>
        /// <param name="hasLowMiles"></param>
        /// <param name="hasPowerWindows"></param>
        /// <param name="hasNavigation"></param>
        /// <param name="hasHeatedSeats"></param>
        /// <returns></returns>
        [Theory]
        [ClassData(typeof(CarTestData))]
        private IEnumerable<Car> ReturnCar(string color = null, string hasSunroof = null
               , string isFourWheelDrive = null, string hasLowMiles = null, string hasPowerWindows = null
               , string hasNavigation = null, string hasHeatedSeats = null, string isAutomatic = null)
        {


            var json = @"[
                  {

                    '_id': '59d2698c2eaefb1268b69ee5',
                    'make': 'Chevy',
                    'year': 2016,
                    'color': 'Gray',
                    'price': 16106,
                    'hasSunroof': false,
                    'isFourWheelDrive': true,
                    'hasLowMiles': true,
                    'hasPowerWindows': false,
                    'hasNavigation': true,
                    'hasHeatedSeats': false,
                    'isAutomatic':  true

                  },
                  {
                    '_id': '59d2698c05889e0b23959106',
                    'make': 'Toyota',
                    'year': 2012,
                    'color': 'Silver',
                    'price': 18696,
                    'hasSunroof': true,
                    'isFourWheelDrive': true,
                    'hasLowMiles': false,
                    'hasPowerWindows': true,
                    'hasNavigation': false,
                    'hasHeatedSeats': true,
                    'isAutomatic': true
                  },
                  {
                    '_id': '59d2698c6f1dc2cbec89c413',
                    'make': 'Mercedes',
                    'year': 2016,
                    'color': 'Black',
                    'price': 18390,
                    'hasSunroof': true,
                    'isFourWheelDrive': false,
                    'hasLowMiles': false,
                    'hasPowerWindows': true,
                    'hasNavigation': true,
                    'hasHeatedSeats': false,
                    'isAutomatic': false
                  },
                  {
                    '_id': '59d2698c340f2728382c0a73',
                    'make': 'Toyota',
                    'year': 2015,
                    'color': 'White',
                    'price': 15895,
                    'hasSunroof': true,
                    'isFourWheelDrive': false,
                    'hasLowMiles': true,
                    'hasPowerWindows': true,
                    'hasNavigation': false,
                    'hasHeatedSeats': true,
                    'isAutomatic': true
                  },
                  {
                    '_id': '59d2698cba9b82c2347cd13a',
                    'make': 'Ford',
                    'year': 2014,
                    'color': 'Gray',
                    'price': 19710,
                    'hasSunroof': false,
                    'isFourWheelDrive': true,
                    'hasLowMiles': false,
                    'hasPowerWindows': false,
                    'hasNavigation': true,
                    'hasHeatedSeats': true,
                    'isAutomatic': false
                  },
                  {
                    '_id': '59d2698ce2e7eeeb4f109001',
                    'make': 'Toyota',
                    'year': 2014,
                    'color': 'Red',
                    'price': 19248,
                    'hasSunroof': true,
                    'isFourWheelDrive': false,
                    'hasLowMiles': true,
                    'hasPowerWindows': true,
                    'hasNavigation': true,
                    'hasHeatedSeats': true,
                    'isAutomatic': false
                  },
                  {
                    '_id': '59d2698cd6a3b8f0dd994c9d',
                    'make': 'Toyota',
                    'year': 2015,
                    'color': 'Black',
                    'price': 13170,
                    'hasSunroof': true,
                    'isFourWheelDrive': false,
                    'hasLowMiles': true,
                    'hasPowerWindows': true,
                    'hasNavigation': false,
                    'hasHeatedSeats': false,
                    'isAutomatic': true
                  },
                  {
                    '_id': '59d2698c86ab54cee8acdc7b',
                    'make': 'Mercedes',
                    'year': 2013,
                    'color': 'Gray',
                    'price': 15669,
                    'hasSunroof': false,
                    'isFourWheelDrive': false,
                    'hasLowMiles': true,
                    'hasPowerWindows': false,
                    'hasNavigation': false,
                    'hasHeatedSeats': false,
                    'isAutomatic': false
                  },
                  {
                    '_id': '59d2698cda9e8d39476c678a',
                    'make': 'Toyota',
                    'year': 2015,
                    'color': 'White',
                    'price': 16629,
                    'hasSunroof': false,
                    'isFourWheelDrive': false,
                    'hasLowMiles': true,
                    'hasPowerWindows': false,
                    'hasNavigation': false,
                    'hasHeatedSeats': true,
                    'isAutomatic': true
                  }
                ]";



            //Turn Json into Array
            JArray jsonArray = JArray.Parse(json);
            //Car List Model
            var cars = jsonArray.ToObject<List<Car>>();

            //Filter clauses
            if (color != null && color != "All")
            {
                cars = cars.Where(r => r.color == color).ToList();
            }
            if (hasSunroof != null && hasSunroof != "All")
            {
                cars = cars.Where(r => r.hasSunroof == (hasSunroof == "Yes" ? true : false)).ToList();
            }
            if (isFourWheelDrive != null && isFourWheelDrive != "All")
            {
                cars = cars.Where(r => r.isFourWheelDrive == (isFourWheelDrive == "Yes" ? true : false)).ToList();
            }
            if (hasLowMiles != null && hasLowMiles != "All")
            {
                cars = cars.Where(r => r.hasLowMiles == (hasLowMiles == "Yes" ? true : false)).ToList();
            }
            if (hasPowerWindows != null && hasPowerWindows != "All")
            {
                cars = cars.Where(r => r.hasPowerWindows == (hasPowerWindows == "Yes" ? true : false)).ToList();
            }
            if (hasNavigation != null && hasNavigation != "All")
            {
                cars = cars.Where(r => r.hasNavigation == (hasNavigation == "Yes" ? true : false)).ToList();
            }
            if (hasHeatedSeats != null && hasHeatedSeats != "All")
            {
                cars = cars.Where(r => r.hasHeatedSeats == (hasHeatedSeats == "Yes" ? true : false)).ToList();
            }
            if (isAutomatic != null && isAutomatic != "All")
            {
                cars = cars.Where(r => r.isAutomatic == (isAutomatic == "Yes" ? true : false)).ToList();
            }


            return cars;



        }
    }
}
