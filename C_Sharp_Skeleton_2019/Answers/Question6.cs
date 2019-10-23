namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question6
    {
        public static int Answer(string[] input)
        {
            //version 3 0.034
            char start = input[0][0];
            char lastI = input[0][input[0].Length-1];
            int i;
            for(i = input.Length-1; i>=0; i--){
                if(input[i].StartsWith(start) && input[i].EndsWith(lastI)){
                    return i;
                }
            } 
            return 0;
        }
    }
}