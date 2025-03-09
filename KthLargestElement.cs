using System;
using System.Collections.Generic;

class KthLargestElement
{
    public static void Main()
    {
        int[] arr = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
        int k = 3;
        Console.WriteLine(FindKthLargest(arr, k));
    }

    public static int FindKthLargest(int[] arr, int k)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException("Input array cannot be null or empty");
        }
        
        int n = nums.Length;
        return QuickSelect(nums, 0, n - 1, n - k);
    }
    public int QuickSelect(int[] nums, int l, int r ,int kthLargest){
        if(nums[l]=nums[r])
            return nums[l];
        int pivotIndex = r;
        Partition(nums,l,r,pivotIndex);
    }
    public void Partition(int[] nums, int l, int r , int pivotIndex){
        for(int i = l ; i < pivotIndex;i++){
            if(nums[l]>nums[pivotIndex]){
                swap(nums,l,pivotIndex)
            }
        }
    }
}
