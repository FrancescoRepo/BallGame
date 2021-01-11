using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    private Text scoreTxt;
    private GameSession session;

    void Start()
    {
        scoreTxt = GetComponent<Text>();
        session = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = session.GetScore().ToString();
    }
}
