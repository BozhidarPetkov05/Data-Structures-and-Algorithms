using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Linked_List
{
    public class CustomLLStack<T>
    {
        private System.Collections.Generic.LinkedList<T> Collection { get; set; }
        public int Count { get; private set; }
    }
}
