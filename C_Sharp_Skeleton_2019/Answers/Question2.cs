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
            int last = risk.Length-1;
            int maxIndex = last;
            int i, j, count;
            int lastRisk = 999;
            for(i =last; i>=0; i--){
                if(risk[i]>=lastRisk){
                    continue;
                }else{
                    count =0;
                    lastRisk = risk[i];
                    for(j =maxIndex; j>=0; j--){
                        if (trader[j] >= risk[i]){
                            count++;
                        }else{
                            break;
                        }
                    }
                    maxIndex = j;
                    answer += (count)*bonus[i];
                }
            }
            return answer;
        }
    }
}