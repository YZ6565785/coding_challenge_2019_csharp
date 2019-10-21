using System;
using System.Collections.Generic;
namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] risk, int[] bonus, int[] trader){
            //VERSION 12
            //speed: 0.23661
            return -1;
            int maxIndex = trader.Length;
            int answer = 0;
            Array.Sort(trader);
            int lowestRiskValue = risk[0];
            foreach(int item in risk)
            {
                if(item<lowestRiskValue){
                    lowestRiskValue = item;
                }
            }
            bool conti = true;
            while(conti){
                int highestBonus =0;
                int count =0;
                conti = false;
                int i = 1;
                while(i<bonus.Length){
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
                    

                    i++;
                }
                int j = 0;
                while(j<maxIndex){
                    if (trader[j] >= risk[highestBonus]){
                        count+=maxIndex - j;
                        maxIndex = j;
                        break;
                    }
                    if (!(conti)){
                        if(trader[j]>=lowestRiskValue){
                            conti = true;
                        } 
                    }
                    j++;
                    
                }
                answer += (count)*bonus[highestBonus];
                bonus[highestBonus] = -1;
                
            }
            return answer;
        }

    }
}