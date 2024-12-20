namespace Assignment7._3._1
{
    //1. You are given the root of a binary search tree (BST) and an integer val.
    //Find the node in the BST that the node's value equals val and return the subtree rooted with that node. If such a node does not exist, return null.

    internal class Program
    {
        static void Main(string[] args)
        {
            //constructing the binary search tree
            TreeNode root = new TreeNode(4,
                             new TreeNode(2,
                                 new TreeNode(1),
                                 new TreeNode(3)),
                             new TreeNode(7));

            Solution solution = new Solution();
            TreeNode result = solution.SearchBST(root, 2);

            if (result != null)
            {
                Console.WriteLine($"Found subtree with root value: {result.val}");
            }
            else
            {
                Console.WriteLine("Value not found in the tree.");
            }
        }
    }
}
