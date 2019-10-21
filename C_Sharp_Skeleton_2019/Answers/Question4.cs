namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question4
    {
        public static int Answer(int[] v, int[] c, int mc)
        {
            //version 4 memo version
            int i, j; 
            int length = v.Length;
            int[,] memo = new int[length+1, mc+1]; 
            for (i = 0; i <= length; i++){ 
                for (j = 0; j <= mc; j++){ 
                    if (i==0 || j==0){
                        memo[i, j] = 0; 
                    }else if (c[i-1] <= j){
                        int a = v[i-1] + memo[i-1, j-c[i-1]];
                        int b = memo[i-1, j];
                        memo[i, j] = (a>b)?a:b;
                    }else{
                        memo[i, j] = memo[i-1, j]; 
                    }
                } 
            } 
            return memo[length, mc]; 
        }
    }
}