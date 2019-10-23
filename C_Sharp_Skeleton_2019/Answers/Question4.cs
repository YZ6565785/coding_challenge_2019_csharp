using System;
using System.Collections.Generic;
namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question4
    {
        public static int Answer(int[] v, int[] c, int mc)
        {
            //version 4 greedy
            Array.Sort(v,c);
            int answer = 0;
            for(int i=v.Length-1;i>=0;i--){
                if(mc==0){
                    break;
                }
                if(c[i]<=mc){
                    mc -=c[i];
                    answer+=v[i];
                }
            }
            return answer;
        }
    }
}