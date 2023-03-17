public class GameManager
{
    private User user;

    public GameManager(User user)
    {
        this.user = user;
    }

    public void AddNewGoal(string name, string description, int targetCompletionCount)
    {
        Goal newGoal = new Goal(name, description, targetCompletionCount);
        user.AddGoal(newGoal);
    }

    public void AddCompletedActivity(ReligiousActivity activity)
    {
        int points = activity.CalculatePointValue();
        user.AddToScore(points);

        List<Goal> goals = user.GetGoals();
        foreach (Goal goal in goals)
        {
            if (activity.GetType() == typeof(ReadingScriptures))
            {
                goal.IncrementCompletionCount();
            }
            else if (activity.GetType() == typeof(AttendingChurch))
            {
                AttendingChurch attendingChurch = (AttendingChurch)activity;
                DateTime activityDate = attendingChurch.GetDate();
                DateTime goalDate = DateTime.Now.Date.AddDays(-7);
                if (activityDate > goalDate)
                {
                    goal.IncrementCompletionCount();
                }
            }
            else if (activity.GetType() == typeof(TempleVisit))
            {
                goal.IncrementCompletionCount();
            }
            else if (activity.GetType() == typeof(FamilyHistory))
            {
                FamilyHistory familyHistory = (FamilyHistory)activity;
                int namesIndexed = familyHistory.GetNamesIndexed();
                if (namesIndexed >= 50)
                {
                    goal.IncrementCompletionCount();
                }
            }
            else if (activity.GetType() == typeof(ServiceActivity))
            {
                ServiceActivity serviceActivity = (ServiceActivity)activity;
                int hoursServed = serviceActivity.GetHoursServed();
                if (hoursServed >= 4)
                {
                    goal.IncrementCompletionCount();
                }
            }
        }
    }

    internal List<Goal> GetCompletedGoals()
    {
        throw new NotImplementedException();
    }

    internal int GetScore()
    {
        throw new NotImplementedException();
    }
}