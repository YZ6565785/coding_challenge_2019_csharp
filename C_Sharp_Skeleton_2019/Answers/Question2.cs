﻿using System;
using System.Collections.Generic;
namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] risk, int[] bonus, int[] trader){
            //VERSION 13
            //speed: 0.23661
            int maxIndex = trader.Length;
            int answer = 0;
            Array.Sort(trader);
            int lowestRiskValue = risk[0];
            int length = risk.Length;
            for(int m =0; m<length; m ++)
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
                for(int i =0; i<length; i ++){
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
                for(int j =0; j<maxIndex; j ++){
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
                }
                answer += (count)*bonus[highestBonus];
                bonus[highestBonus] = -1;
                
            }
            return answer;
        }

    }
}