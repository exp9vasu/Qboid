using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool GameOver;
    public bool Level1Cleared;
    public GameObject GameOverPanel;
    public GameObject Level1Complete;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GameOver = false;
        Level1Cleared = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver)
        {
            GameOverPanel.SetActive(true);
            Script_Player.instance.cubeStop();
        }

        if(Level1Cleared)
        {
            Level1Complete.SetActive(true);
            Script_Player.instance.cubeStop();
        }
    }
}
