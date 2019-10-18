namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question6
    {
        public static int Answer(string[] input)
        {
            //version 2 0.1233
            int answer = 0;
            bool getSameStart = false;
            char start = input[0][0];
            char lastI = input[0][input[0].Length-1];
            for (int i = 1; i<input.Length; i++){
                if(start.Equals(input[i][0])){
                    if(!getSameStart){
                        getSameStart = true;
                    }
                    if(lastI.Equals(input[i][input[i].Length-1])){
                        answer = i;
                    }
                }
            }    
            if(answer ==0 && getSameStart){
                answer = -1;
            }
            return answer;
        }
    }
}