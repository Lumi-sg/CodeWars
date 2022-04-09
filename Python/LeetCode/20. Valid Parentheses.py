class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        bracketMap = {")" : "(", "]": "[", "}": "{"}
        
        for l in s:
            if l in bracketMap:
                if stack and stack[-1] == bracketMap[l]:
                    stack.pop()
                else:
                    return False
            else:
                stack.append(l)
        if not stack:
            return True
        else:
            return False
        
