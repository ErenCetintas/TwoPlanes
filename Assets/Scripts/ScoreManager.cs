using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        Time.timeScale=1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + score;
        Debug.Log("score : "+score);
    }
}
