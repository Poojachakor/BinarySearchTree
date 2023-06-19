namespace BSTProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree!");
            BST binarySearchTree = new BST();
            binarySearchTree.Insert(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Display();
        }
    }
}