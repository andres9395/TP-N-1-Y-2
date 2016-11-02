using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public float maxSpeed = 18f;
    public float boundary = 10;
    public float speed = 1f;
    public float initialX = 0f;
    public float initialY = -4.48f;
    private Vector3 initialPosition;
    private Rigidbody2D rb2d;
    private float horizontalSpeed;
    

    void Start()
    {
        transform.position = new Vector3(initialX, initialY, transform.position.z);
        initialPosition = transform.position;
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        horizontalSpeed = 0;

    }

    void Update()
    {
        horizontalSpeed = Input.GetAxis("Horizontal") * speed;

        rb2d.AddForce(Vector2.right * horizontalSpeed);

        //Speed limiting
        if (rb2d.velocity.x > maxSpeed)
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }
        if (rb2d.velocity.x < -maxSpeed)
        {
            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        }

        //boundary limiting
        if (Mathf.Abs(transform.position.x - initialPosition.x) > boundary)
        {
            rb2d.velocity = new Vector2(-rb2d.velocity.x, rb2d.velocity.y);
        }

    }
}
