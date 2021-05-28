using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public player myP;
    public static ScoreManager sm;
    public TextMeshProUGUI text;
    int score;

    void Start()
    {
        if (sm == null)
        {
            sm = this;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = myP.point.ToString();
    }

    public void ChangeScore( int point )
    {
        score = point;
        text.text = score.ToString();
    }
}
