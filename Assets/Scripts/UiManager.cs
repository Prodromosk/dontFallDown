using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;

    public GameObject DontFallDownPanel;
    public GameObject GameOverPanelHolder;
    public GameObject tapText;
    public Text score;
    public Text highScore1;
    public Text highScore2;
    //public Text liveScore;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        highScore1.text = "High Score: " + PlayerPrefs.GetInt("highScore");
    }

    public void GameStart()
    {
        tapText.SetActive(false);
        DontFallDownPanel.GetComponent<Animator>().Play("panelUp");
    }

    public void GameOver()
    {
        //liveScore.text = PlayerPrefs.GetInt("score").ToString();
        score.text = PlayerPrefs.GetInt("score").ToString();
        highScore2.text = PlayerPrefs.GetInt("highScore").ToString();
        GameOverPanelHolder.SetActive(true);
    }

    public void StartOver()
    {
        SceneManager.LoadScene(0);
    }
        

    // Update is called once per frame
    void Update()
    {
        
    }
}
