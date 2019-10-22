using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] risk, int[] bonus, int[] trader){
            //VERSION 15
            //speed: 0.156127
            int maxIndex = trader.Length-1;
            int answer = 0;
            Array.Sort(trader);
            Array.Sort(bonus,risk);
            int length = risk.Length;
            int i, j;
            int lastRisk = 999;
            for(i =length-1; i>=0; i--){
                if(risk[i]>=lastRisk){
                    continue;
                }else{
                    int count =0;
                    lastRisk = risk[i];
                    for(j =maxIndex; j>=0; j--){
                        if (trader[j] >= risk[i]){
                            count++;
                        }else{
                            maxIndex = j;
                            break;
                        }
                    }
                    answer += (count)*bonus[i];
                }
            }
            return answer;
        }
    }
}