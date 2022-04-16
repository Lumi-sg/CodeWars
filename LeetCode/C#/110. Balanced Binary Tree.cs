using System;
public class Solution {
    public bool IsBalanced(TreeNode root) 
    { 
        bool balanced = true;

        DFS(root);
        return balanced;

        int DFS(TreeNode node)
        {
            if (node == null)
                return 0;
            int left = DFS(node.left);
            int right = DFS(node.right);

            if (Math.Abs(left - right) > 1)
                {
                    balanced = false;
                }
            return Math.Max(left,right) + 1;
        }
    }
}