public class User
{
    private string name;
    private List<Goal> goals;
    private int score;

    public User(string name)
    {
        this.name = name;
        this.goals = new List<Goal>();
        this.score = 0;
    }

    public string GetName()
    {
        return name;
    }

    public List<Goal> GetGoals()
    {
        return goals;
    }

    public int GetScore()
    {
        return score;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void AddToScore(int points)
    {
        score += points;
    }
}