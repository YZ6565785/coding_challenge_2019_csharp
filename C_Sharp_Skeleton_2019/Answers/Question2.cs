namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] risk, int[] bonus, int[] trader){
            //VERSION 10
        //speed: 0.0729
        int answer = 0;
        int lowestRiskValue = risk[0];
        foreach(int item in risk)
        {
            if(item<lowestRiskValue){
                lowestRiskValue = item;
            }
        }
        bool conti = true;
        while(conti){
            

            int highestBonus =0;
            int count =0;
            conti = false;
            int i = 1;
           
            while(i<bonus.Length){
                if(bonus[i] != -1){
                    if  (bonus[highestBonus] <= bonus[i]){
                        if(risk[highestBonus]>risk[i] || (bonus[highestBonus] < bonus[i] && risk[highestBonus]==risk[i]) ){
                            bonus[highestBonus] = -1;
                            highestBonus = i;
                        }else if(bonus[highestBonus] == bonus[i] && (risk[highestBonus]==risk[i] || risk[highestBonus]<risk[i]) ){
                            bonus[i] = -1;
                        }else{
                            highestBonus = i;
                        }
                    }else{
                        if(risk[highestBonus]==risk[i] || risk[highestBonus]<risk[i] ){
                            bonus[i] = -1;
                        }
                    }
                }
                

                i++;
            }
            int j = 0;
            while(j<trader.Length){
                if(trader[j] != -1){
                    if (trader[j] >= risk[highestBonus]){
                        trader[j] = -1;
                        count++;
                    }
                    if (!(conti)){
                        if(trader[j]>=lowestRiskValue){
                            conti = true;
                        } 
                    }
                }
                j++;
                
            }
            answer += (count)*bonus[highestBonus];
            bonus[highestBonus] = -1;
            
        }
        return answer;
        }

    }
}