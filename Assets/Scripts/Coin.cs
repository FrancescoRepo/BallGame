using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int scoreValue = 1;
    private GameSession session;
    [SerializeField] private AudioClip pickedCoinClip;

    void OnTriggerEnter2D(Collider2D col)
    {
        session = FindObjectOfType<GameSession>();
        session.AddScore(scoreValue);
        AudioSource.PlayClipAtPoint(pickedCoinClip, transform.position);
        Destroy(gameObject);
    }
}
