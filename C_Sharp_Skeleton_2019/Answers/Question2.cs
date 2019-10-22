using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] risk, int[] bonus, int[] trader){
            //VERSION 15.1
            //speed: 0.143
            
            int answer = 0;
            Array.Sort(trader);
            Array.Sort(bonus,risk);
            int maxIndex = risk.Length-1;
            int i, j, count, ans, start, end;
            int lastRisk = 999;
            for(i =risk.Length-1; i>=0; i--){
                if(maxIndex == -1){
                    break;
                }
                if(risk[i]>=lastRisk){
                    continue;
                }else{
                    //binary search
                    count =0;
                    ans = -1;
                    start = 0; 
                    end = maxIndex;
                    while(start<=end){
                        int mid = (start + end) / 2;
                        if (trader[mid] < risk[i]){ 
                            start = mid + 1; 
                        }else{ 
                            ans = mid; 
                            end = mid - 1; 
                        } 
                    }
                    count = (ans==-1)? 0 : maxIndex-ans+1;
                    maxIndex = (ans==-1)? maxIndex : ans-1;
                    answer += (count)*bonus[i];
                }
            }
            return answer;
        }
    }
}