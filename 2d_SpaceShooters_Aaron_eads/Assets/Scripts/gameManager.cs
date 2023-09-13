using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;

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
        
    }

    public void IncreaseScore(int amount)
    {
        score+= amount;
        scoreText.text = "Score: " + score;
    }
}
