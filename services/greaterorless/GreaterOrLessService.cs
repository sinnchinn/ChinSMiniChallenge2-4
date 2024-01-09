namespace ChinSMiniChallenge2_4.services.greaterorless;

public class GreaterOrLessService : IGreaterOrLessService
{

    public string GreaterOrLess(string num1, string num2)
    {
        bool isTrue = int.TryParse(num1, out int realNum1);
        bool isTrue2 = int.TryParse(num2, out int realNum2);

        if (isTrue == true && isTrue2)
        {
            if (realNum1 > realNum2)
            {
                return $"{realNum1} is greater than {realNum2}";
            }
            else if (realNum1 < realNum2)
            {
                return $"{realNum1} is less than {realNum2}";
            }
            else
            {
                return $"{realNum1} and {realNum2} are equal";
            }
        }
        else
        {
            return "those are not numbers";
        }

    }

}
