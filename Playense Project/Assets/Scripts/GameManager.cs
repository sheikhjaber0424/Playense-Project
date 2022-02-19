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

    public GameObject background;

    public TextMeshProUGUI HighScoreText;
    public TextMeshProUGUI DiamondText;
    // Start is called before the first frame update

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        timer = 0;
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
            Debug.Log(tilesSpeed);
        }


    }

    public void UpdateScore(int addToScore)
    {
        score = score + addToScore;
        HighScoreText.text = "High-Score  " + score;
    }

    public void GameOver()
    {
        background.SetActive(true);
    }
}
