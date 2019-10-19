﻿using System;
using System.Collections.Generic;
namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question3
    {
        public static int Answer(int[] scores, int[] alice)
        {
            //version 4 0.0428
            Array.Sort(scores);
            Array.Sort(alice);
            int count = 1;
            int answer = 0;
            int scoreIndex = scores.Length-1;
            int alicePtr = alice.Length-1;
            int rank = 1;
            int aliceIndex = alicePtr;
            while (scoreIndex>=0){
                if(scoreIndex>0 && scores[scoreIndex] == scores[scoreIndex-1]){
                    scoreIndex--;
                    continue;
                }	
                
                int repeat = 0;
                
                while(aliceIndex>=0 && alice[aliceIndex] >= scores[scoreIndex]){
                    repeat++;
                    aliceIndex--;
                }
                if(repeat >=count){
                    count = repeat;
                    answer = rank; 
                }
                
                if(aliceIndex < 0){
                    break;
                }
                if(scoreIndex==0 && alice[aliceIndex]<scores[scoreIndex] && aliceIndex>=count-1){
                    answer = rank+1;
                }
                scoreIndex--;
                
                rank++;
            }
            return answer;
        }
    }
}