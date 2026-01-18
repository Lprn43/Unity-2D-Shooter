using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        print("niga");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            rb.linearVelocityY = 1;
            print("W basildi");
        }
        else if (Input.GetKey(KeyCode.S) == true)
        {
            rb.linearVelocityY = -1;
            print("S basildi");
        }
        else if (Input.GetKey(KeyCode.W) == false && Input.GetKey(KeyCode.S) == false)
        {
            rb.linearVelocityY = 0;
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            rb.linearVelocityX = 1;
            print("D basildi");
            rb.transform.rotation = new Quaternion(0,180,0,0);
        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            rb.linearVelocityX = -1;
            print("A basildi");
            rb.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false)
        {
            rb.linearVelocityX = 0;
        }
        if (rb.linearVelocityY > 0 && rb.linearVelocityX > 0) 
        {
            rb.linearVelocityX = 0.7071f;
            rb.linearVelocityY = 0.7071f; 
        }
        else if (rb.linearVelocityY > 0 && rb.linearVelocityX < 0)
        {
            rb.linearVelocityX = -0.7071f;
            rb.linearVelocityY = 0.7071f;
        }
        else if (rb.linearVelocityY < 0 && rb.linearVelocityX > 0)
        {
            rb.linearVelocityX = 0.7071f;
            rb.linearVelocityY = -0.7071f;
        }
        else if (rb.linearVelocityY < 0 && rb.linearVelocityX < 0)
        {
            rb.linearVelocityX = -0.7071f;
            rb.linearVelocityY = -0.7071f;
        }
        //else { rb.linearVelocity = new Vector2(0, 0); }
    }
}
