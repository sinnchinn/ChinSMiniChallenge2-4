namespace ChinSMiniChallenge2_4.services.addnumbers;

public class AddNumbersService : IAddNumbersService
{

    public int total = 0;

    public string AddNumbers(string firstNumber, string secondNumber)
    {
        bool isTrue = int.TryParse(firstNumber, out int realFirstNum);
        bool isTrue2 = int.TryParse(secondNumber, out int realSecondNum);

        if(isTrue == true && isTrue2 == true)
        {
            total = realFirstNum + realSecondNum;
            return $"{realFirstNum} plus {realSecondNum} equals {total}.";
        } else {
            return "those are not numbers!";
        }
    }
}