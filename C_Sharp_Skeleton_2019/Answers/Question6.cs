namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question6
    {
        public static int Answer(string[] input)
        {
            //version 3 0.038
            return -1;
            int answer = 0;
            bool getSameStart = false;
            char start = input[0][0];
            char lastI = input[0][input[0].Length-1];
            int i = input.Length-1;
            while(i>=0){
                if(input[i].StartsWith(start)){
                    if(!getSameStart){
                        getSameStart = true;
                    }
                    if(input[i].EndsWith(lastI)){
                        return i;
                    }
                }
                i--;
            }   
            if(answer ==0 && getSameStart){
                answer = -1;
            }
            return answer;
        }
    }
}