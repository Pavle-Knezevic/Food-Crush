using UnityEngine;

public class LevelTimer : Level
{
    public int timeInSeconds;
    public int targetScore;

    private float timer;
    private bool timeOut = false;

    // Start is called before the first frame update
    void Start()
    {
        type = LevelType.TIMER;

    }

    // Update is called once per frame
    void Update()
    {
        if (!timeOut)
        {
            timer += Time.deltaTime;

            if (timeInSeconds - timer <= 0)
            {
                if (currentScore >= targetScore)
                {
                    GameWin();
                }
                else
                {
                    GameLose();
                }

                timeOut = true;
            }
        }
    }
}
