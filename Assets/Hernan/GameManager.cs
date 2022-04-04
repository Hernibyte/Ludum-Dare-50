using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] float gameTime;
    [SerializeField] int points;
    [SerializeField] int excusesAmount;
    [SerializeField] DialogoController dialogoController;
    [SerializeField] MenuManager menuManager;

    [SerializeField] GameObject _espawnervieja;

    const int maxExcuses = 10;
    public bool ifEndGame = false;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (!ifEndGame)
        {
            gameTime -= Time.deltaTime;
            menuManager.UpdateTimer((int)gameTime);
            CheckTime();
        }
        SetPause();
    }

    void SetPause()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
            menuManager.ShowMenu();
        }
    }

    void CheckTime()
    {
        if (gameTime <= 0)
        {
            ifEndGame = true;
            if (excusesAmount >= maxExcuses)
            {
                dialogoController.SetGoodEnd();
            }
            else
            {
                dialogoController.SetBadEnd();
            }
            dialogoController.MostrarDialog();
            Instantiate(_espawnervieja, transform);
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
            menuManager.excusebar.Actualizarbarra(excusesAmount);
        }
    }
}
