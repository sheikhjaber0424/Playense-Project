using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
   

    public float downforce = 100.0f;
    public float upforce = 100.0f;
    public float tilesSpeed = 2.0f;
    public float timer;
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
}
