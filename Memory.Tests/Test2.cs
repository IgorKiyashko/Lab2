using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
namespace Memory.Tests;

public sealed class StackandHeapTests
{
    [Test]
    public void StackTest()
    {
        int price = 20000;
        Car testCar = new Car("Audi", price);
        Assert.That(testCar.price, Is.EqualTo(20000));
        Assert.That(testCar.manufacturer, Is.EqualTo("Audi"));
    }


    public class Car
    {
        public string manufacturer;
        public int price;

        public Car(string manufacturer, int price)
        {
            this.manufacturer = manufacturer;
            this.price = price;
        }
        
    }





    [Test]
    public static void HeapTest()
    {
        int price = 5000;
        Tables testTable = new Tables("Wood", price);
        IncreaseTablesPrice(testTable, 5000);
        Assert.That(testTable.price, Is.EqualTo(10000));
    }
    static void IncreaseTablesPrice(Tables tables, int priceIncrease)
    {
        tables.price += priceIncrease;
    }
    public class Tables
    {
        public string sort;
        public int price;

        public Tables(string sort, int price)
        {
            this.sort = sort;
            this.price = price;
        }

    }

}





