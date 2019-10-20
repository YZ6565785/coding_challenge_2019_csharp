namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question4
    {
        public static int Answer(int[] v, int[] c, int mc)
        {
            //version 3 greedy
            //asfasdfsa
            quickSort2(v,0,v.Length-1,c);
            int answer = 0;
            for(int i=v.Length-1;i>=0;i--){
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
        
        

        static void quickSort2(int[] arr, int low, int high, int[] arr2){
		
            if (arr == null || arr.Length == 0){
                return;
            }
            if (low >= high){
                return;
            }
            // pick the pivot
            int middle = low + (high - low) / 2;
            int pivot = arr[middle];
            // make left < pivot and right > pivot
            int i = low, j = high;
            while (i <= j) {
                while (arr[i] < pivot) {
                    i++;
                }

                while (arr[j] > pivot) {
                    j--;
                }

                if (i <= j) {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    int temp2 = arr2[i];
                    arr2[i] = arr2[j];
                    arr2[j] = temp2;
                    i++;
                    j--;
                }
            }
            // recursively sort two sub parts
            if (low < j)
                quickSort2(arr, low, j, arr2);

            if (high > i)
                quickSort2(arr, i, high, arr2);
            //
        }
    }
}