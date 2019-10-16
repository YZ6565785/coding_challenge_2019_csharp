using System;
using System.Collections.Generic;
namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question3
    {
        public static int Answer(int[] scores, int[] alice)
        {
            //version 3
            Array.Sort(scores);
            int lastRank = -1;
            IDictionary<int, int> dict = new Dictionary<int, int>();
            int count = 1;
            int answer = 0;
            for (int loop = 0; loop<alice.Length;loop++){
                int rank =1;
                int i = scores.Length-1;
                int lastScore = -1;
                while (i >= 0){
                    if (i < 0 ){
                        break;
                    }
                    if (alice[loop] < scores[i]){
                        if(lastScore != scores[i]){
                            rank ++;
                        }
                    }else{
                        break;
                    }
                    lastScore = scores[i];
                    i--;
                }
                if(dict.ContainsKey(rank)){
                    dict[rank]++;
                }else{
                    dict.Add(rank,1);
                }
                if(dict[rank] >=count){
                    if(dict[rank]==count && rank>lastRank){
                        lastRank = rank;
                        answer = rank;
                    }else if(dict[rank]>count){
                        answer = rank;
                        count = dict[rank];
                        
                    }
                    
                }
            }
            
            return answer;
        }
    }
}