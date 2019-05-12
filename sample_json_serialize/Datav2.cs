using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_json_serialize
{

    public class Datav2Child
    {
        public int dataChild1 = 19;
    }

    public class Datav2
    {
        public int data3 = 18;
        public List<string> data2 = new List<string>{"xx", "yy"};
        public Datav2Child child2;
    }
}
