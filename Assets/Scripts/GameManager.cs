using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public static string playerName;
    public static int bestScore = 0;
    public static int score = -1;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public static void setScore(int newScore)
    {
        if (newScore > bestScore)
        {
            bestScore = newScore;
        }

        score = newScore;
    }
}
