# type: ignore
class Solution:
    def diameterOfBinaryTree(self, root: Optional[TreeNode]) -> int:
        
        def depth(root):
            if not root:
                return 0
            left = depth(root.left)
            right = depth(root.right)
            self.ans = max(self.ans, left + right)
            return max(left, right) + 1
        
        self.ans = 0
        depth(root)
        return self.ans