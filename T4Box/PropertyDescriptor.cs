using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Box
{
    public class PropertyDescriptor
    {
        public Type Type { get; set; }
        public string Name { get; set; }
    }

    public class ReadOnlyPropertyDescriptor : PropertyDescriptor
    {
        public object InitializeValue { get; set; }
    }
}
