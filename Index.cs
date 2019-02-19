using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Index
    {
        private int[] array;
        public int Size { get; set; }

        public Index(int size)
        {
            Size = size;
            array = new int[size];
        }

        public int this[int i]
        {
            get { return array[i]; }
            set { array[i] = (int)Math.Pow(value, 2); }
        }
    }
}
