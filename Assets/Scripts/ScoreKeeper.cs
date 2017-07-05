using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    private Text mytext;
    public static int score = 0;

	// Use this for initialization
	void Start () {
        mytext = GetComponent<Text>();
        ResetScore();
    }
	
	// Update is called once per frame
	void Update () {
        
	}


    public void Score (int points)
    {
        score += points;
        mytext.text = score.ToString();
    }

    public static void ResetScore()
    {
        score = 0;
    }

}
