﻿ using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = player.position.z.ToString("0");
        
    }
}
