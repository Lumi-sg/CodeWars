public class KthLargest {
    PriorityQueue<int, int> minimumHeap = new PriorityQueue<int, int>();
    int kThLargest;
    
    public KthLargest(int k, int[] nums) {        
        kThLargest = k;
        foreach(var n in nums){
            Add(n);
        }
    }
    
    public int Add(int val)
    {
        minimumHeap.Enqueue(val, val);
        if(minimumHeap.Count > kThLargest){
            minimumHeap.Dequeue();
        }
        
        return minimumHeap.Peek();
    }
}