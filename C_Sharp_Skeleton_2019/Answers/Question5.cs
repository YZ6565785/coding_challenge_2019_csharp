using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question5
    {
        public static int Answer(int[] input)
        {
            //using List!!
            quickSort2(input,1,input.Length-2);
            //Instance[] arr = new Instance[];
            List<int> freq = new List<int>();
            List<int> time = new List<int>();
            int launchT = input[1];
            int launchF = input[2];
            freq.Add(launchF);
            time.Add(launchT);
            int i;
            int count = 1;
            bool notFound;
            for(i = 3; i < input.Length-1; i+=2){
                notFound = true;
                int modifiedF, modifiedT, modifyIndex;
                notCounter = false;
                modifyIndex = -1;
                modifiedF = 0;
                for(int index  = 0; index <freq.Count; index++){
                    if(freq[index] == input[i+1]){
                        notFound = false;
                        break;
                    }else{
                        if(modifyIndex ==-1 && time[index] != -1){
                            modifiedF = input[i+1];
                            modifiedT = time[index]+ (Math.Abs(modifiedF-freq[index]));
                            if(modifiedT <= input[i]){
                                modifyIndex = index;
                            }
                        }
                    }
                }
                if(notFound){
                    if(modifyIndex != -1){
                        time[modifyIndex] = -1;
                        time.Add(input[i]);
                        freq.Add(modifiedF);
                        continue;
                    }
                    freq.Add(input[i+1]);
                    time.Add(input[i]);
                    count++;
                }
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
            int middle = low + (high - low) / 2;
            if(middle%2 ==0){
                middle++;
            }
            int pivot = arr[middle];
            int afterPivot = arr[middle+1];
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
            if (low < j)
                quickSort2(arr, low, j);

            if (high > i)
                quickSort2(arr, i, high);
        }
    }
}