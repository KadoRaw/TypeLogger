using NUnit.Framework;
using TypeLogger;
using System;
using System.Collections.Generic;

namespace TypeLoggerUnitTest
{
    [TestFixture]
    public class Tests
    {
        [TestCase("kado")]
        [TestCase(6)]
        [TestCase('l')]
        [TestCase(typeof(ITestable))] // cannot work
        [TestCase(typeof(Product))] // cannot work
        [TestCase(9)]
        [TestCase(6)]
        
        public void IsTypeLogWrking<T>(T value) // T
        {
            var typeLogger = new TypeLogger.TypeLogger();
            Type type = typeof(T);
            typeLogger.DisplayInfo<T>();

            Assert.AreEqual(type.FullName, typeLogger.FullName);
            Assert.AreEqual(type.Name, typeLogger.Name);
            Assert.AreEqual(type.GetInterfaces(), typeLogger.types);
            Assert.AreEqual(type.BaseType, typeLogger.BaseType);
            Assert.AreEqual(type.IsEnum, typeLogger.IsEnum);
            Assert.AreEqual(type.IsAbstract, typeLogger.IsAbstract);
            Assert.AreEqual(type.IsInterface, typeLogger.IsInterface);
            Assert.AreEqual(type.IsPrimitive, typeLogger.IsPrimitive);
            Assert.AreEqual(type.IsValueType, typeLogger.IsValueType);
            Assert.AreEqual(type.IsClass, typeLogger.IsClass);

        }
        
    }
}