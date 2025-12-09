using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 5f;
    public colliding jump;
    public Rigidbody2D rb;
    public Vector3 Direction = new Vector3(0f, 1f, 0f);
    public float ShootForce = 50f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 beweging = new Vector3(horizontalInput, 0f);
        transform.Translate(beweging * moveSpeed *  Time.deltaTime);
        if(jump.canJump == true)
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                rb.AddForce(Direction * ShootForce);
            
            }

        }
    }
}
