using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OnlineLottery.Models
{
    public class Common
    {
        public string ConvertEToMNumber(string text)
        {
            return text.Replace('0', '၀')
                .Replace('1', '၁')
                .Replace('2', '၂')
                .Replace('3', '၃')
                .Replace('4', '၄')
                .Replace('5', '၅')
                .Replace('6', '၆')
                .Replace('7', '၇')
                .Replace('8', '၈')
                .Replace('9', '၉').Replace(',', ',');
        }
    }
}
