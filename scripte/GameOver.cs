using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameOver instance;
    void Awake()
    {
        instance = this;
    }
    public void Restart()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene(1);
    }
    public void Mainmenu()
    {
        Debug.Log("Mainmenu");
        SceneManager.LoadScene(0);

    }
}
