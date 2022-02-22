using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; 

    public float downforce = 700.0f;
    public float upforce = 400.0f;
    public float tilesSpeed = 2.0f;
    public float timer;
    public int score = 0;
    public int score1 = 0;

    public bool isGameActive;

    public GameObject background;

    public TextMeshProUGUI HighScoreText;
    public TextMeshProUGUI DiamondText;

    public Material[] material;
   

    // Start is called before the first frame update

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        timer = 0;
        isGameActive = true;


    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 10)
        {
            tilesSpeed = 20.0f;
            downforce = 1400;
            upforce = 600;

            
        }


    }

    public void UpdateScore(int addToScore)
    {
        score = score + addToScore;
        HighScoreText.text = "High-Score  " + score;
    }
     public void UpdateScore2(int addToScore)
    {
        score1 = score1 + addToScore;
        DiamondText.text = "Diamonds  " + score1;
    }

    public void GameOver()
    {
        background.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
