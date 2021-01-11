using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    private int _score = 0;

    public void AddScore(int scoreToAdd)
    {
        _score += scoreToAdd;
    }

    public int GetScore()
    {
        return _score;
    }
}
