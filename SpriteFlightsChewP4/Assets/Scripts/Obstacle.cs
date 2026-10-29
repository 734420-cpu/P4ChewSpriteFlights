using System.Net.Mail;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float minSize = 0.5f;
    public float maxSize = 2.0f;
    public float minSpeed = 125f;
    public float maxSpeed = 250f;
    public float maxSpinSpeed = 10f;

    Rigidbody2D rb;

    void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSize, randomSize, 1);

        float randomSpeed = Random.Range(minSpeed, maxSpeed) / randomSize;
        Vector2 randomDirection = Random.insideUnitCircle;

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(randomDirection * randomSpeed);
        float randomeTorque = Random.Range(-maxSpinSpeed, maxSpinSpeed);
        rb.AddTorque(randomeTorque);
    }
}