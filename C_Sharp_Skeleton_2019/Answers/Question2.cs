using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] risk, int[] bonus, int[] trader){
            //VERSION 13
            //speed: 0.223
            int maxIndex = trader.Length-1;
            int answer = 0;
            Array.Sort(trader);
            int lowestRiskValue = risk[0];
            int length = risk.Length;
            for(int m =1; m<length; m ++)
            {
                if(risk[m]<lowestRiskValue){
                    lowestRiskValue = risk[m];
                }
            }
            bool conti = true;
            while(conti){
                int highestBonus =0;
                int count =0;
                conti = false;
                for(int i =1; i<length; i ++){
                    if(bonus[i] != -1){
                        if(bonus[highestBonus] < bonus[i]){
                            if(risk[highestBonus]>=risk[i]){
                                bonus[highestBonus] = -1;
                                highestBonus = i;
                            }else{
                                highestBonus = i;
                            }
                        }else{
                            if (risk[highestBonus]<=risk[i]){
                                bonus[i] = -1;
                            }else if(bonus[highestBonus] == bonus[i]&&risk[highestBonus]>risk[i]){
                                bonus[highestBonus] = -1;
                                highestBonus = i;
                            }
                            
                        }
                    }
                }
                for(int j =maxIndex; j>=0; j--){
                    if (trader[j] >= risk[highestBonus]){
                        count++;
                    }else{
                        if(trader[j]>=lowestRiskValue){
                            conti = true;
                        } 
                        maxIndex = j;
                        break;
                    }
                }
                answer += (count)*bonus[highestBonus];
                bonus[highestBonus] = -1;
                
            }
            return answer;
        }

    }
}