using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float gameTime;
    [SerializeField] int points;
    [SerializeField] int excusesAmount;
 
    const int maxExcuses = 10;
    
    void Update()
    {
        gameTime -= Time.deltaTime;
        CheckTime();
    }

    void CheckTime()
    {
        if (gameTime <= 0)
            Debug.Log("bad end");
    }

    void CheckExcuses()
    {
        if (excusesAmount >= maxExcuses)
            Debug.Log("good end");
    }

    public void AddPoints(int point)
    {
        points += point;
    }

    public void AddExcuses(int excuse)
    {
        excusesAmount += excuse;
        CheckExcuses();
    }
}
