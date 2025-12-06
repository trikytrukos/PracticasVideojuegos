using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Vector2 initialVelocity = new Vector2(5f, 10f);
    [SerializeField] private float velocitiyMultiplier = 1.2f;

    private Rigidbody2D ballRb;
    private bool isBallMoving;

    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();

        // IMPORTANTE: Desactivar la física inicialmente
        ballRb.simulated = false;
        isBallMoving = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isBallMoving)
        {
            Launch();
        }
    }

    private void Launch()
    {
        transform.parent = null;
        ballRb.simulated = true;
        ballRb.bodyType = RigidbodyType2D.Dynamic;
        ballRb.velocity = initialVelocity.normalized * 8f; // Normalizar para consistencia
        isBallMoving = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject);
            ballRb.velocity *= velocitiyMultiplier; 
            GameManager.Instance.BlockDestroyed();
        }
    }
}