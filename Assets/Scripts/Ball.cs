using System.IO;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float ballSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        launch();
    }

    private void launch()
    {
        Vector2 direction = Vector2.zero;

        if(Random.value <= 0.5f)
        {
            direction = Vector2.right;

        }

        else
        {
            direction = Vector2.left;
        }

        rb.linearVelocity = direction * ballSpeed;

    }

}
