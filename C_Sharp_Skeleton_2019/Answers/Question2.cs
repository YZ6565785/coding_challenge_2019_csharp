namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] risk, int[] bonus, int[] trader){
            //VERSION 8
            //speed: 0.101
            int lowestRiskValue = risk[0];
            foreach(int each in risk){
                if(each<lowestRiskValue){
                    lowestRiskValue = each;
                }
            }
            return question02Rec(risk, bonus, trader, true, lowestRiskValue);
        }
        static int question02Rec(int[] risk, int[] bonus, int[] trader, bool conti, int lowestRiskValue){
            if (conti == false){
                return 0;
            }
            int highestBonus =0;
            int count =0;
            conti = false;
            for(int i = 0; i<bonus.Length; i++){
                if  (bonus[highestBonus] == bonus[i]){
                    if (risk[i] < risk[highestBonus]){
                        bonus[highestBonus] = -1;
                        highestBonus = i;
                    }
                }else if(bonus[highestBonus] < bonus[i]){
                    highestBonus = i;
                }
            }
            for(int i = 0; i<bonus.Length; i++){
                if (!(conti)){
                    if(trader[i]>=lowestRiskValue){
                        conti = true;
                    } 
                }
                    
                if (trader[i] == -1){
                    continue;
                }
                if (trader[i] >= risk[highestBonus]){
                    trader[i] = -1;
                    count +=1;
                }
                
            }
            int answer = (count)*bonus[highestBonus];
            bonus[highestBonus] = -1;
            return answer + question02Rec(risk, bonus, trader, conti, lowestRiskValue);
        }

    }
}