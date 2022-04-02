using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float gameTime;
    [SerializeField] int points;
    [SerializeField] int excusesAmount;

    const int maxExcuses = 10;
    bool ifEndGame = false;

    void Update()
    {
        if (!ifEndGame)
        {
            gameTime -= Time.deltaTime;
            CheckTime();
        }
    }

    void CheckTime()
    {
        if (gameTime <= 0)
        {
            Debug.Log("bad end");
            ifEndGame = true;
        }
    }

    void CheckExcuses()
    {
        if (excusesAmount >= maxExcuses)
        {
            Debug.Log("good end");
            ifEndGame = true;
        }
    }

    public void AddPoints(int point)
    {
        points += point;
    }

    public void AddExcuses(int excuse)
    {
        if (!ifEndGame)
        {
            excusesAmount += excuse;
            CheckExcuses();
        }
    }
}
