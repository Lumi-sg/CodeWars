# type: ignore
class Solution:
    def isBalanced(self, root: Optional[TreeNode]) -> bool:
        
        self.balanced = True

        def DFS(root):
            if not root:
                return 0
            left = DFS(root.left)
            right = DFS(root.right)
            
            if abs(left - right) > 1:
                self.balanced = False
            return max(left, right) + 1
        DFS(root)
        return self.balanced
    