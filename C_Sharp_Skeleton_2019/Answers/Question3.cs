using System;
using System.Collections.Generic;
namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question3
    {
        public static int Answer(int[] scores, int[] alice)
        {
            //version 4 2.74
            return -1;
            Array.Sort(scores);
            Array.Sort(alice);
            int count = 1;
            int answer = 0;
            int alicePtr = alice.Length-1;
            int rank = 1;
            int i, repeat, j;
            for(i =scores.Length-1; i>=0; i --){
                if(i>0 && scores[i] == scores[i-1]){
                    continue;
                }	
                
                for(j= alicePtr; j>=0;j--){
                    if(alice[j] < scores[i]){
                        break;
                    }
                }
                repeat = alicePtr-j;
                alicePtr = j;
                if(repeat >=count){
                    count = repeat;
                    answer = rank; 
                }
                if(j < 0){
                    break;
                }
                if(i==0 && alice[j]<scores[i] && j>=count-1){
                    answer = rank+1;
                }
                rank++;
            }
            return answer;
        }
    }
}