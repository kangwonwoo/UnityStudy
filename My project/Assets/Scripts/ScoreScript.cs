using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private Text score1;
    private Text score2;
    private int count1;
    private int count2;

    // Start is called before the first frame update
    void Start()
    {
        this.score1 = GameObject.Find("Score1").GetComponent<Text>();
        this.score2 = GameObject.Find("Score2").GetComponent<Text>();
        count1 = 0;
        count2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncScore1()
    {
        count1++;
        score1.text = count1.ToString();
    }
    public void IncScore2()
    {
        count2++;
        score2.text = count2.ToString();
    }
}
