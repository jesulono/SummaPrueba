using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SummaPrueba.App_Start.Clases;
using System.Collections.Generic;

namespace SummaPrueba.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MediaAgenteA()
        {
            Agente agente = new A();

            List<double> list = new List<double>()
            {
                5,20,3.5,10
            };

            double result = agente.getMedia(list);
            Assert.AreEqual(9.625, result);
        }

        [TestMethod]
        public void MediaAgenteB()
        {
            Agente agente = new B();

            List<double> list = new List<double>()
            {
                5,20,3.5,10
            };

            double result = agente.getMedia(list);
            double expected = 4.0 / ((1.0 / 5.0) + (1.0 / 20.0) + (1.0 / 3.5) + (1.0 / 10.0));
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MediaAgenteC()
        {
            Agente agente = new C();

            List<double> list = new List<double>()
            {
                5,20,3.5,10
            };

            double result = agente.getMedia(list);
            Assert.AreEqual(7.5, result);
        }

        [TestMethod]
        public void EscaleraAgenteA() 
        {
            Agente agente = new A();

            string result = agente.getStaircase(4);
            Assert.AreEqual("   #\n  ##\n ###\n####\n", result);
        }

        [TestMethod]
        public void EscaleraAgenteB()
        {
            Agente agente = new B();

            string result = agente.getStaircase(4);
            Assert.AreEqual("####\n ###\n  ##\n   #\n", result);
        }

        [TestMethod]
        public void EscaleraAgenteC()
        {
            Agente agente = new C();

            string result = agente.getStaircase(4);
            Assert.AreEqual("   ####   \n  ######  \n ######## \n##########\n ######## \n  ######  \n   ####   \n", result);
        }
    }
}
