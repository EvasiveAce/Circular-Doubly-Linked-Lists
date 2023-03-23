using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularDoubly
{
    public class LinkedList<T> : ICollection<T>, IEnumerable<T>
    {

        public int count;
        public int Count
        {
            get
            {
                return count;
            }
            private set
            {

            }
        }
        
        LLNode<T>? head;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            count++;
            if (head == null)
            {
                head = new LLNode<T>(item);
                head.Next = head;
                head.Previous = head;
                return;
            }
            var node = new LLNode<T>(item);

            // link new head with old head
            node.Next = head;
            // link new head to old head's prev
            node.Previous = head.Previous;
            // link prev's next to new node
            head.Previous.Next = node;
            // update old head's prev to new head
            head.Previous = node;
            // update head
            head = node;

        }

        public string itemToString(T item)
        {
            var nodeToGet = head;
            if (head.Value.Equals(item))
            {
                var stringToUse = $"Previous Node: {nodeToGet.Previous.Value}\n";
                stringToUse += $"Current Node: {nodeToGet.Value}\n";
                stringToUse += $"Next Node: {nodeToGet.Next.Value}\n";
                return stringToUse;
            }
            // THIS WORKS^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            //same code basically as remove, to get everything to work
            while (nodeToGet is not null)
            {
                if (nodeToGet.Next is not null && nodeToGet.Next.Value.Equals(item))
                {
                    // this is so jumbled i have no idea why there needs to be so many next's
                    var stringToUse = $"Previous Node: {nodeToGet.Next.Next.Value}\n";
                    stringToUse += $"Current Node: {item}\n";
                    stringToUse += $"Next Node: {nodeToGet.Value}\n";
                    
                    return stringToUse;
                }
                // if not found
                nodeToGet = nodeToGet.Next;
            }
            return "NOT FOUND";
        }

        // Infinite loop
        // Should fix
        public bool Remove(T item)
        {
            var nodeToFind = head;
            // Basically checks to see if head is actually the value before doing everything
            if (head.Value.Equals(item))
            {
                count--;
                head = head.Next;
                return true;
            }

            // while its not null
            while (nodeToFind is not null)
            {
                // if the NEXT is not null, as well as equals to the item we are looking to find
                if(nodeToFind.Next is not null && nodeToFind.Next.Value.Equals(item))
                {
                    count--;
                    // Set the next to the next next to essentially remove it 
                    nodeToFind.Next = nodeToFind.Next.Next;
                    return true;
                }
                // if not found
                nodeToFind = nodeToFind.Next;
            }
            return false;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
