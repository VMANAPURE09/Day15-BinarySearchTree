using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(56);
            bst.Add(30);
            bst.Add(70);

            Console.WriteLine("Preorder Traversal- ");
            bst.TravarsePreorder(bst.Root);
            Console.WriteLine("Inorder Traversal- ");
            bst.TraverseInOrder(bst.Root);
            Console.WriteLine("Postorder Traversal- ");
            bst.TraversePostOrder(bst.Root);
        }
    }
}
