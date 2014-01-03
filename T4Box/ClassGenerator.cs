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

        [Test]
        public void WriteCustomizedClassTest()
        {
            var template = new ClassWithArgumentsTemplate();
            template.ClassName = "MyClass";
            template.NameSpaceName = "MyNs";
            template.Value = false;
            Console.Write(template.TransformText());
        }
    }
}
