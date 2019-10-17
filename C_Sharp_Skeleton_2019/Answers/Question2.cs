using System;
using System.Collections.Generic;
namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] risk, int[] bonus, int[] trader){
            //VERSION 11
            //speed: 0.24400
            int maxIndex = trader.Length;
            int answer = 0;
            Array.Sort(trader);
            int lowestRiskValue = 9999;
            bool foundLowestRisk = false;
            bool conti = true;
            while(conti){
                if(lowestRiskValue != 9999){
                    foundLowestRisk = true;
                }
                int highestBonus =0;
                int count =0;
                conti = false;
                int i = 1;
            
                while(i<bonus.Length){
                    if (!foundLowestRisk){
                        if(risk[i]<lowestRiskValue){
                            lowestRiskValue = risk[i];
                        }
                    }
                    if(bonus[i] != -1){
                        if  (bonus[highestBonus] <= bonus[i]){
                            if(risk[highestBonus]>risk[i] || (bonus[highestBonus] < bonus[i] && risk[highestBonus]==risk[i]) ){
                                bonus[highestBonus] = -1;
                                highestBonus = i;
                            }else if(bonus[highestBonus] == bonus[i] && (risk[highestBonus]==risk[i] || risk[highestBonus]<risk[i]) ){
                                bonus[i] = -1;
                            }else{
                                highestBonus = i;
                            }
                        }else{
                            if(risk[highestBonus]==risk[i] || risk[highestBonus]<risk[i] ){
                                bonus[i] = -1;
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