using UnityEngine;

public class background : MonoBehaviour
{
    public Rigidbody2D rb, player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y-rb.transform.position.y > 1.28f)
        {
            rb.transform.position = new Vector3(rb.transform.position.x, rb.transform.position.y + 2.56f, rb.transform.position.z);
        }
        if (player.transform.position.y - rb.transform.position.y < -1.28f)
        {
            rb.transform.position = new Vector3(rb.transform.position.x, rb.transform.position.y - 2.56f, rb.transform.position.z);
        }
        if (player.transform.position.x - rb.transform.position.x > 1.92f)
        {
            rb.transform.position = new Vector3(rb.transform.position.x + 3.84f, rb.transform.position.y, rb.transform.position.z);
        }
        if (player.transform.position.x - rb.transform.position.x < -1.92f)
        {
            rb.transform.position = new Vector3(rb.transform.position.x - 3.84f, rb.transform.position.y, rb.transform.position.z);
        }
    }
}
