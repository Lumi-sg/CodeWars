public class MinStack {

    Stack<int> stack = new Stack<int>();

    public MinStack() 
    {
        
    }
    
    public void Push(int val) 
    {
        stack.Push(val);
    }
    
    public void Pop() 
    {
        stack.Pop();
    }
    
    public int Top() 
    {
        return stack.Peek();
    }
    
    public int GetMin() 
    {
        return stack.Min();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */