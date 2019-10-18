namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question6
    {
        public static int Answer(string[] input)
        {
            //version 1
            int answer = 0;
            bool getSameStart = false;
            string start = input[0];
            int lastI = start.Length-1;
            for (int i = 1; i<input.Length; i++){
                if(start[0].Equals(input[i][0])){
                    if(!getSameStart){
                        getSameStart = true;
                    }
                    
                    if(start[lastI].Equals(input[i][input[i].Length-1])){
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