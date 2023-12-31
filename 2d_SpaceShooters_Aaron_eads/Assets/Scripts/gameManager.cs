using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    int score = 0;
    bool isGameover = false;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject gameOverText;

    public static gameManager instance;
   

    private void Awake()
    {
        instance = this; 
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit")&& isGameover)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void IncreaseScore(int amount)
    {
        score+= amount;
        scoreText.text = "Score: " + score;
    }
    public void InstitateGameover()
    {
        isGameover = true;
        gameOverText.SetActive(true);
    }
}
