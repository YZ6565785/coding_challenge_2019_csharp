using System;
using System.Collections.Generic;
namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question3
    {
        public static int Answer(int[] scores, int[] alice)
        {
            //version 4 0.042
            Array.Sort(scores);
            Array.Sort(alice);
            int count = 1;
            int answer = 0;
            int scoreIndex = scores.Length-1;
            int alicePtr = alice.Length-1;
            for (int i = scores.Length-1; i>=0;i--){
                
                int j = alicePtr;
                int repeat = 0;
                
                while(j>=0 && alice[j] >= scores[i]){
                    repeat++;
                    j--;
                }
                int rank =scores.Length-i;
                if(repeat >=count){
                    count = repeat;
                    answer = rank; 
                }
                if(j <0){
                    break;
                }
                alicePtr = j;
            }
            return answer;
        }
    }
}