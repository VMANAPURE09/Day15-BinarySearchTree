using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public bool Add(int value)
        {
            Node before = null, after = Root;
            while (after != null)
            {
                before = after;
                if (value < after.Data)
                    after = after.LeftNode;
                else if (value > after.Data)
                    after = after.RightNode;
                else
                {
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }

        public void TravarsePreorder(Node Parent)
        {
            if (Parent != null)
            {
                Console.WriteLine(Parent.Data + " ");
                TravarsePreorder(Parent.LeftNode);
                TravarsePreorder(Parent.RightNode);
            }
        }


        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.WriteLine(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }

        public void TraversePostOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.WriteLine(parent.Data + " ");
            }
        }
        public int getsize(Node Root)
        {
            if (Root == null)
            {
                return 0;
            }
            int leftSize = getsize(Root.LeftNode);
            int rightSize = getsize(Root.RightNode);

            return leftSize + rightSize + 1;
        }
    }
}
