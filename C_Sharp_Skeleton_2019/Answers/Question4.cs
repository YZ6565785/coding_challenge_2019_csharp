namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question4
    {
        public static int Answer(int[] v, int[] c, int mc)
        {
            //version 2 greedy
            quickSort(v,c);
            int answer = 0;
            for(int i=0;i<v.Length;i++){
                if(mc==0){
                    break;
                }
                if(c[i]<=mc){
                    mc -=c[i];
                    answer+=v[i];
                }
            }
            return answer;
        }
        
        

        static void quickSort(int[] arr1, int[] arr2){
		    quickSortRec(arr1,0,arr1.Length-1,arr2);
	    }
        static void quickSortRec(int[] arr1, int lo, int hi,int[] arr2){
            if(lo<hi){
                int iPivot = partition(arr1,lo,hi,arr2);
                quickSortRec(arr1,lo,iPivot-1,arr2);
                quickSortRec(arr1,iPivot+1,hi,arr2);
            }
            
        }
        static int partition(int[] arr1,int low,int high,int[] arr2){
            int pivot = arr1[high];  
            int i = (low-1); // index of smaller element 
            for (int j=low; j<high; j++) 
            { 
                // If current element is smaller than the pivot 
                if (arr1[j] > pivot) 
                { 
                    i++; 
        
                    // swap arr[i] and arr[j] 
                    int temp = arr1[i]; 
                    arr1[i] = arr1[j]; 
                    arr1[j] = temp; 
                    
                    int temp2 = arr2[i]; 
                    arr2[i] = arr2[j]; 
                    arr2[j] = temp2; 
                } 
            } 
        
            // swap arr[i+1] and arr[high] (or pivot) 
            int tem = arr1[i+1]; 
            arr1[i+1] = arr1[high]; 
            arr1[high] = tem;   
            
            // swap arr[i+1] and arr[high] (or pivot) 
            int tem2 = arr2[i+1]; 
            arr2[i+1] = arr2[high]; 
            arr2[high] = tem2; 
        
            return i+1; 
        }
    }
}