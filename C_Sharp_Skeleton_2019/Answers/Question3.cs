using System;
using System.Collections.Generic;
namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question3
    {
        public static int Answer(int[] scores, int[] alice)
        {
            //version 4 2.74
            Array.Sort(scores);
            Array.Sort(alice);
            int count = 1;
            int answer = 0;
            int alicePtr = alice.Length-1;
            int rank = 1;
            int aliceIndex = alicePtr;
            int scoreIndex, repeat;
            for(scoreIndex =scores.Length-1; scoreIndex>=0; scoreIndex --){
                if(scoreIndex>0 && scores[scoreIndex] == scores[scoreIndex-1]){
                    continue;
                }	
                repeat = 0;
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
                rank++;
            }
            return answer;
        }
    }
}