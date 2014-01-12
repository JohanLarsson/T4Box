using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace T4Box
{
    using Templates;

    public class ClassGenerator
    {
        [Test]
        public void SimpleClassTemplate()
        {
            var template = new SimpleClassTemplate();
            Console.Write(template.TransformText());
        }

        [Test]
        public void DynamicTemplate_TransformText()
        {
            var template = new DynamicTemplate();
            template.ClassName = "MyClass";
            template.NameSpaceName = "MyNs";
            template.Value = false.ToString().ToLower();
            Console.Write(template.TransformText());
        }

        [Test]
        public void DynamicTemplate_WriteCode()
        {
            var template = new DynamicTemplate();
            Console.Write(template.WriteCode(false,"MyClass", "ns"));
        }
    }
}
