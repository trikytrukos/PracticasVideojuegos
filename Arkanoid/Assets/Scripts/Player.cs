using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float moveSpeed;

    private float bounds = 4.5f;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        // Mover primero
        transform.position += new Vector3(moveInput * moveSpeed * Time.deltaTime, 0f, 0f);

        // Luego limitar
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -bounds, bounds);
        transform.position = clampedPosition;
    }
}