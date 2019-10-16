using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question1
    {
        public static int Answer(double initialLevelOfDebt, double interestPercentage, double repaymentPercentage)
        {
            double p = 0.01;
            double repayment = initialLevelOfDebt*repaymentPercentage*p;
            double answer = initialLevelOfDebt*10*p;
            while(repayment<=initialLevelOfDebt){
                initialLevelOfDebt = initialLevelOfDebt*(1+(interestPercentage)*p) - repayment;
                answer = answer + repayment;
            }
            return Convert.ToInt16(Math.Round(answer + initialLevelOfDebt));

        }
    }
}
