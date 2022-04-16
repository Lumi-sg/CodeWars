using System;
public class Solution {
    public int DiameterOfBinaryTree(TreeNode root) 
    {
         int max = 0;

        Depth(root);

        return max;

        int Depth(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int left = Depth(node.left);
            int right = Depth(node.right);
            max = Math.Max(max, left + right);

            return Math.Max(left, right) + 1;
        }
    }
}