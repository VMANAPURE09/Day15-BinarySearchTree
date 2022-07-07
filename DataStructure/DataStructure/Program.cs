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
            bst.Add(22);
            bst.Add(11);
            bst.Add(3);
            bst.Add(40);
            bst.Add(16);
            bst.Add(60);
            bst.Add(65);
            bst.Add(95);
            bst.Add(63);
            bst.Add(67);


            Console.WriteLine("Preorder Traversal- ");
            bst.TravarsePreorder(bst.Root);
            Console.WriteLine("Inorder Traversal- ");
            bst.TraverseInOrder(bst.Root);
            Console.WriteLine("Postorder Traversal- ");
            bst.TraversePostOrder(bst.Root);

            Console.WriteLine("The Size of Binary Tree is- " + bst.getsize(bst.Root));

            Console.WriteLine("----------------------");
            if (bst.Search(bst.Root, 63) == null)
            {
                Console.WriteLine("Key does not exist");
            }
            else
            {
                Console.WriteLine("Key exist");
            }

        }
    }
}
