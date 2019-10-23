using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] risk, int[] bonus, int[] trader){
            //VERSION 15.1 reverse
            //speed: 0.143
            return -1;
            int answer = 0;
            Array.Sort(trader);
            Array.Sort(bonus,risk);
            int maxIndex = risk.Length-1;
            int i, j;
            int lastRisk = 999;
            int count;
            for(i =risk.Length-1; i>=0; i--){
                if(maxIndex == -1){
                    break;
                }
                if(risk[i]>=lastRisk){
                    continue;
                }else{
                    count = 0;
                    for(j =maxIndex; j>=0; j--){
                            if (trader[j] < risk[i]){
                                break;
                            }
                        }
                        count = maxIndex-j;
                        maxIndex = j;
                
                    answer += (count)*bonus[i];
                    
                }
            }
            return answer;
        }
    }
}