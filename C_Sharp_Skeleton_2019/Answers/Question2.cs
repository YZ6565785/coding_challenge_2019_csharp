using System;
using System.Collections.Generic;
namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] risk, int[] bonus, int[] trader){
            //VERSION 14
            //speed: 0.202
            int maxIndex = trader.Length;
            int answer = 0;
            Array.Sort(trader);
            int remain = trader.Length;
            while(remain>0){
                int highestBonus =0;
                int i = 1;
                while(i<bonus.Length){
                    if(bonus[i] != -1){
                        if(bonus[highestBonus] < bonus[i]){
                            if(risk[highestBonus]>=risk[i]){
                                bonus[highestBonus] = -1;
                                remain--;
                                highestBonus = i;
                            }else{
                                highestBonus = i;
                            }
                        }else{
                            if (risk[highestBonus]<=risk[i]){
                                bonus[i] = -1;
                                remain--;
                            }else if(bonus[highestBonus] == bonus[i]&&risk[highestBonus]>risk[i]){
                                bonus[highestBonus] = -1;
                                remain--;
                                highestBonus = i;
                            }
                            
                        }
                    }
                    i++;
                }
                int j = 0;
                while(j<maxIndex){
                    if (trader[j] >= risk[highestBonus]){
                        answer += (maxIndex - j)* bonus[highestBonus];
                        maxIndex = j;
                        break;
                    }
                    j++;
                }
                bonus[highestBonus] = -1;
                remain--;
            }
            return answer;
        }

    }
}