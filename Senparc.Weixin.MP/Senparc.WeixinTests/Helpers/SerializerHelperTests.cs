﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Senparc.Weixin.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senparc.Weixin.Helpers.Tests
{
    [TestClass()]
    public class SerializerHelperTests
    {
        [TestMethod()]
        public void GetJsonStringTest()
        {
            var obj = new RootClass()
            {
                A = "Jeffrey",
                B = 31,
                C=null,
                ElementClassA = new ElementClass() { A = "Jeffrey", B = null },
                ElementClassB = null
            };

            DateTime dt1 = DateTime.Now;
            SerializerHelper js = new SerializerHelper();
            var json = js.GetJsonString(obj);
            Console.WriteLine(json);
            Console.WriteLine((DateTime.Now - dt1).TotalMilliseconds);
        }
    }

    public class RootClass
    {
        public string A { get; set; }
        public int B { get; set; }
        public int? C { get; set; }
        public ElementClass ElementClassA { get; set; }
        public ElementClass ElementClassB { get; set; }
    }

    public class ElementClass
    {
        public string A { get; set; }
        public string B { get; set; }
    }
}