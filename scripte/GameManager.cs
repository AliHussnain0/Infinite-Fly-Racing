using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour


{
    public static GameManager instance;
    //  [SerializeField] Animator transition;
    public GameState State;
    public static event Action<GameState> OnGameStateChange;
    // Start is called before the first frame update

    private void Awake()
    {
        instance= this;

        Debug.Log(1);
    }
    public void Startgame()
    {


        Application.targetFrameRate = 60;
        StartCoroutine(startgame1());
    }

    // Update is called once per frame
    IEnumerator startgame1()
    {

       // transition.SetTrigger("ends");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
      //  transition.SetTrigger("start");
        
    }
    private void Start()
    {
      //  UpdateGameState(GameState.ScreenSetup);
    }
    public void UpdateGameState(GameState newState)
    {
        State   = newState;
        switch (newState)
        {
            case GameState.ScreenSetup:
                HandelScreenSetup();
                break;
            case GameState.planemovement:
                break;
            case GameState.endgame:
                break;
        }
        OnGameStateChange ?.Invoke(newState);
    }

   private void HandelScreenSetup()
    {

    }
    public enum GameState
    {
        ScreenSetup,
        planemovement,
            endgame,
    }
}
