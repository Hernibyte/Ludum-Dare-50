using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float gameTime;
    [SerializeField] int points;
    [SerializeField] int excusesAmount;
    [SerializeField] DialogoController dialogoController;

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
            ifEndGame = true;
            if (excusesAmount >= maxExcuses)
            {
                Debug.Log("good end");
                dialogoController.SetGoodEnd();
            }
            else
            {
                Debug.Log("bad end");
                dialogoController.SetBadEnd();
            }
            dialogoController.MostrarDialog();
        }
    }

    void CheckExcuses()
    {
        if (excusesAmount >= maxExcuses)
            excusesAmount = maxExcuses;
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
