using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Computer : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    public float topBound =3.65f;
    public float bottomBound =-3.65f;

    private GameObject Ball;
    private Vector2 ballPos;

    void Start()
    {
        startPosition = transform.position;         //Baslangic Konumu
    }
    void Update()
    {
        Move();
    }
    void Move()
    {
        if (!Ball) Ball = GameObject.FindGameObjectWithTag("Ball");
        if(Ball.GetComponent<Ball>().BallDirection == Vector2.right)
        {
            ballPos = Ball.transform.localPosition;
            if(transform.localPosition.y > bottomBound && ballPos.y < transform.localPosition.y)
            {
                transform.localPosition += new Vector3(0, -speed * Time.deltaTime,0);
            }
            if(transform.localPosition.y < topBound && ballPos.y > transform.localPosition.y)
            {
                transform.localPosition += new Vector3(0, speed * Time.deltaTime, 0);
            }
        }
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;         //Sifirlanma sonrasi baslangic konumuna donus
    }
}
