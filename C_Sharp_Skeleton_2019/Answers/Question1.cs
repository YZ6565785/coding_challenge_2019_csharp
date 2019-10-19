using System;
namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question1
    {
        public static int Answer(double initialLevelOfDebt, double interestPercentage, double repaymentPercentage)
        {
            //version 3.1
            //speed: 0.0039
            double p = 0.01;
            double repayment = initialLevelOfDebt*repaymentPercentage*p;
            double answer = initialLevelOfDebt*10*p;
            while(repayment<initialLevelOfDebt){
                initialLevelOfDebt *= initialLevelOfDebt *(1+interestPercentage*p) - repayment;
                answer += repayment;
            }
            return Convert.ToInt16(answer + initialLevelOfDebt);

        }
    }
}
