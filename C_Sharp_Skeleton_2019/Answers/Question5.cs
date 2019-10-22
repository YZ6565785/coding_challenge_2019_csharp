using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    struct Instance{
        public int time;
        public int freq;
        public Instance(int Time, int Freq)
        {
            time = Time;
            freq = Freq;
        }
    }
    public class Question5
    {
        public static int Answer(int[] input)
        {   
            quickSort2(input,1,input.Length-2);
            //using struct
            List<Instance> list = new List<Instance>();
            list.Add(new Instance(input[1], input[2]));
            
            int i;
            int count = 1;
            bool notFound;
            int length = input.Length;
            for(i = 3; i < length-1; i+=2){
                notFound = true;
                bool notCounter, readyModify, matched;
                int modifiedF, modifiedT, modifyIndex;
                notCounter = false;
                matched = false;
                modifyIndex = -1;
                modifiedF = 0;
                //using struct
                
                for(int index  = list.Count-1; index >=0; index--){
                    
                    if(list[index].freq == input[i+1]){
                        notFound = false;
                        break;
                    }else{
                            modifiedF = input[i+1];
                            modifiedT = list[index].time + (Math.Abs(modifiedF-list[index].freq));
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
                        //using struct
                        
                        list[modifyIndex] = new Instance(input[i],modifiedF);
                        continue;
                    }
                    //using struct
                    
                    list.Add(new Instance(input[i],input[i+1] ));
                    
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