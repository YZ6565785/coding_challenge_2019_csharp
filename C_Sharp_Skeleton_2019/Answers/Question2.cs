using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] risk, int[] bonus, int[] trader){
            //VERSION 15.1 reverse
            //speed: 0.143
            
            int answer = 0;
            Array.Sort(trader);
            Array.Sort(bonus,risk);
            int maxIndex = risk.Length-1;
            int i, j;
            int lastRisk = 999;
            for(i =risk.Length-1; i>=0; i--){
                if(maxIndex == -1){
                    break;
                }
                if(risk[i]>=lastRisk){
                    continue;
                }else{
                    int count = 0;
                    if(maxIndex>=10){
                        int ans = -1;
                        int start = 0; 
                        int end = maxIndex;
                        while(start<=end){
                            int mid = (start + end) / 2; 
                            //System.out.println("middle : " + Integer.toString(mid));
                            if (trader[mid] < risk[i]){ 
                                start = mid + 1; 
                            }else{ 
                                ans = mid; 
                                end = mid - 1; 
                            } 
                        }
                        //System.out.println("ans : " + Integer.toString(ans));
                        count = (ans==-1)? 0 : maxIndex-ans+1;
                        maxIndex = (ans==-1)? maxIndex : ans-1;
                    }else{
                        for(j =maxIndex; j>=0; j--){
                            if (trader[j] < risk[i]){
                                break;
                            }
                        }
                        count = maxIndex-j;
                        maxIndex = j;
                    }
                
                    answer += (count)*bonus[i];
                    
                }
            }
            return answer;
        }
    }
}