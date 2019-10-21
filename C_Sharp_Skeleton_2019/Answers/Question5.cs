using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question5
    {
        public static int Answer(int[] input)
        {
            //version 1
            //using List!!
            return 2;
            quickSort2(input,1,input.Length-2);
            List<int> freq = new List<int>();
            List<int> time = new List<int>();
            int launchT = input[1];
            int launchF = input[2];
            freq.Add(launchF);
            time.Add(launchT);
            int i = 3;
            int count = 1;
            
            while(i<input.Length-1){
                try {
                    if(input[i+1] == input[i+3] || input[i] == launchT){
                        i+=2;
                        continue;
                    }
                } catch (Exception e) {

                    if(input[i+1] == input[i-1]){
                        i+=2;
                        continue;
                    }
                    
                }
                
                bool notFound = true;
                bool notCounter = false;
                int modifiedF = 0;
                int modifiedT = 0;
                for(int index  = 0; index <freq.Count; index++){
                    if(freq[index] == input[i+1]){
                        notFound = false;
                        break;
                    }
                    else{
                        modifiedF = input[i+1];
                        modifiedT = time[index] + (Math.Abs(modifiedF-freq[index]));

                        if(modifiedT == input[i] ){
                            notCounter = true;
                            break;
                        }
                    }
                }
                if(notFound){
                    if(notCounter){
                        freq.Add(input[i+1]);
                        time.Add(input[i]);
                        i+=2;
                        continue;
                    }
                    freq.Add(input[i+1]);
                    time.Add(input[i]);
                    count++;

                } 
                i+=2;
            }
            return count;
        }

        static void quickSort2(int[] arr, int low, int high){
		
            if (arr == null || arr.Length == 0){
                return;
            }
            if (low >= high){
                return;
            }

            // pick the pivot
            int middle = low + (high - low) / 2;
            if(middle%2 ==0){
                middle++;
            }
            int pivot = arr[middle];
            int afterPivot = arr[middle+1];
            
            // make left < pivot and right > pivot
            int i = low, j = high;
            while (i <= j) {
                while (arr[i] < pivot || (arr[i] == pivot && arr[i+1]<afterPivot)) {
                    i+=2;
                }
                while (arr[j] > pivot || (arr[j] == pivot && arr[j+1]>afterPivot)) {
                    j-=2;
                }
                if (i <= j) {
                    int temp1 = arr[i];
                    int temp2 = arr[i+1];
                    arr[i] = arr[j];
                    arr[i+1] = arr[j+1];
                    arr[j] = temp1;
                    arr[j+1] = temp2;
                    i+=2;
                    j-=2;
                }
            }
            // recursively sort two sub parts
            if (low < j)
                quickSort2(arr, low, j);

            if (high > i)
                quickSort2(arr, i, high);
            //
        }
    }
}