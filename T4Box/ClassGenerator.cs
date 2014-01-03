using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace T4Box
{
    public class ClassGenerator
    {
        [Test]
        public void WriteClassWithoutArgumentsTest()
        {
            var template = new SimpleClassTemplate();
            Console.Write(template.TransformText());
        }
    }
}
