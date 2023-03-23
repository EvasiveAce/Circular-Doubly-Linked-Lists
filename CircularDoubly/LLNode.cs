using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// took from your notes, simply uses next and previous
namespace CircularDoubly
{
    public class LLNode<T>
    {
        public T Value { get; set; }
        public LLNode<T> Next { get; set; }
        public LLNode<T> Previous { get; set; }


        public LLNode(T element)
        {
            this.Value = element;
        }
    }
}
