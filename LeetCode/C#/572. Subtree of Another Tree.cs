public class Solution 
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
	{
		if ((root == null && subRoot == null) && (root != null && subRoot == null))
			return true;
		else if (root == null && subRoot != null)
			return false;
		else // when both are not null
		{
			if (isSameTree(root, subRoot))  // Call our recursive function
				return true;
			else
				return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot); // Move down the next low Level
		} 
	}
	public bool isSameTree(TreeNode root, TreeNode subroot)
	{
		if (root == null && subroot == null)
			return true;
		else if (root != null && subroot != null && root.val == subroot.val)
			return isSameTree(root.left, subroot.left) && isSameTree(root.right, subroot.right);
		else    // if one of them is null
			return false;
	}
}