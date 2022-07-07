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
            bst.Add(26);
            bst.Add(11);
            bst.Add(3);
            bst.Add(42);
            bst.Add(12);
            bst.Add(45);
            bst.Add(77);
            bst.Add(98);
            bst.Add(79);
            bst.Add(69);


            Console.WriteLine("Preorder Traversal- ");
            bst.TravarsePreorder(bst.Root);
            Console.WriteLine("Inorder Traversal- ");
            bst.TraverseInOrder(bst.Root);
            Console.WriteLine("Postorder Traversal- ");
            bst.TraversePostOrder(bst.Root);

            Console.WriteLine("The Size of Binary Tree is- " + bst.getsize(bst.Root));

        }
    }
}
