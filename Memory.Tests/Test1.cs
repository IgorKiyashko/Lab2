using System;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
namespace Memory.Tests;

public sealed class ValueandReferenceTypeTests
{
    [Test]
    public void ValueTypetest1()
    {
        int i = 100;
        ChangeValue(i);
        Assert.That(i, Is.EqualTo(100));
        void ChangeValue(int x) => x = 200;
        
    }
    


    [Test]
    public static void ReferenceTypetest()
    {
        Student std1 = new Student();

        std1.StudentName = "Hello";

        ChangeReferenceType(std1);
        Assert.That(std1.StudentName, Is.EqualTo("World"));
    }
    public static void ChangeReferenceType(Student std2)
    {
        std2.StudentName = "World";
    }

    public class Student
    {

        public string StudentName { get; set; }

    }
}





