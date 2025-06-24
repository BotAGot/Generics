using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class BlockList<T> where T : class
    {
        LinkedList<IBlock<T>> list;
        public BlockList()
        {
            list = new LinkedList<IBlock<T>>();
        }
        public void AddBlock(IBlock<T> block)
        {
            list.AddLast(block);
        }
        public T RunFlow(T input)
        {
            LinkedListNode<IBlock<T>> node = list.First;
            while (node != null)
            {
                input = node.Value.Process(input);
                node = node.Next;
            }
            return input;
        }
    }
}
