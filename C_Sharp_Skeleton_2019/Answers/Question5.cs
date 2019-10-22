using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question5
    {
        public static int Answer(int[] input)
        {   
            quickSort2(input,1,input.Length-2);
            //using List!!
            List<int> freq = new List<int>();
            List<int> time = new List<int>();
            int launchT = input[1];
            int launchF = input[2];
            
            freq.Add(launchF);
            time.Add(launchT);
            

            int i;
            int count = 1;
            bool notFound;
            int length = input.Length;
            for(i = 3; i < length-1; i+=2){
                notFound = true;
                bool  matched;
                int modifiedF, modifiedT, modifyIndex;
                matched = false;
                modifyIndex = -1;
                modifiedF = 0;
                //using list
                
                for(int index  = freq.Count-1; index >=0; index--){
                    
                    if(freq[index] == input[i+1]){
                        notFound = false;
                        break;
                    }else{
                            modifiedF = input[i+1];
                            modifiedT = time[index] + (Math.Abs(modifiedF-freq[index]));
                            if(modifiedT <= input[i] &&  !matched){
                                if(modifiedT == input[i]){
                                    matched = true;
                                }
                                modifyIndex = index;
                            }
                    }
                }
                if(notFound){
                    
                    if(modifyIndex != -1){
                        //using list
                        time[modifyIndex] = input[i];
                        freq[modifyIndex] = modifiedF;
                        continue;
                    }
                    //using list
                    freq.Add(input[i+1]);
                    time.Add(input[i]);
                    count++;
                }
                
            }
            
            return count;
        }
        static void quickSort2(int[] arr, int low, int high){
            if (low >= high){
                return;
            }
            int middle = low + (high - low) / 2;
            if(middle%2 ==0){
                middle++;
            }
            int pivot = arr[middle];
            int i = low, j = high;
            while (i <= j) {
                while (arr[i] < pivot) {
                    i+=2;
                }
                while (arr[j] > pivot) {
                    j-=2;
                }
                if (i <= j) {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;
                    temp = arr[i+1];
                    arr[i+1] = arr[j+1];
                    arr[j+1] = temp;
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