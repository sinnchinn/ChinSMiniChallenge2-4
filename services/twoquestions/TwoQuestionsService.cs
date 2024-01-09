namespace ChinSMiniChallenge2_4.services.twoquestions;
public class TwoQuestionsService : ITwoQuestionsService
{

    public string userName = "";
    public string wakeUpTime = "";
    public string userInput = "";

    public string TwoQuestions(string userName, string wakeUpTime)
    {
        userInput = $"Your name is {userName} and you woke up at {wakeUpTime}";
        return userInput;
    }
}
