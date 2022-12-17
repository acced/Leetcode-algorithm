``` c#
public int searchFirstEqualElement(int[] nums, int target) {

        int low=0,high=nums.Length-1,mid=low+((high-low)>>1);
        while (low<=high)
        {
            mid=low+((high-low)>>1);
            if (nums[mid]>target)
        {
            high=mid-1;
            
        }
        else if (nums[mid]<target)
        {
            low =mid+1;
        }
        else {

            if(mid==0||nums[mid-1] != target) return mid;
            high=mid-1;

        }    
        }
        return -1;
        
       }

       public int searchLastEqualElement(int[] nums, int target) {

        int low=0,high=nums.Length-1,mid=low+((high-low)>>1);
        while (low<=high)
        {
            mid=low+((high-low)>>1);
            if (nums[mid]>target)
        {
            high=mid-1;
            
        }
        else if (nums[mid]<target)
        {
            low =mid+1;
        }
        else {

            if(mid==nums.Length-1||nums[mid+1] != target) return mid;
            low=mid+1;

        }     
        }
        return -1;
        
       }

         public int searchFirstGreaterElement(int[] nums, int target) {
        int low=0,high=nums.Length-1,mid=low+((high-low)>>1);
        while (low<=high)
        {
            mid=low+((high-low)>>1);
            if (nums[mid]>=target)
        {
            if(mid==0||nums[mid-1] < target) return mid;
            high=mid-1;
        }
        else 
        {
            low =mid+1;
        }       
        }
        return -1;
        
       }

         public int searchLastGreaterElement(int[] nums, int target) {
        int low=0,high=nums.Length-1,mid=low+((high-low)>>1);
        while (low<=high)
        {
            mid=low+((high-low)>>1);
            if (nums[mid]<=target)
        {
            if(mid==nums.Length-1||nums[mid+1] > target) return mid;
            low = mid + 1;
        }
        else 
        {
            high=mid-1;
        }       
        }
        return -1;
        
       }

```
