using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D body;
    [SerializeField] private float speed = 2f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var X = Input.GetAxis("Horizontal") * speed;        
        body.AddForce(new Vector2(X, 0));
    }
}
