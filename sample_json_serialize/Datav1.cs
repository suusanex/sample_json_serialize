using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_json_serialize
{
    public class Datav1Child
    {
        public int dataChild1;
    }

    public class Datav1
    {
        public int data1;
        public List<string> data2;
        public Datav1Child child;
        public byte[] bytedata;
    }
}
