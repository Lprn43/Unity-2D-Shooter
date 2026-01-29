using UnityEngine;

public class spawnpointlocation : MonoBehaviour
{
    public float x, y;
    public Rigidbody2D player;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerx, playery,playerz;
        playerx = player.transform.position.x;
        playery = player.transform.position.y;
        playerz = player.transform.position.z;
        rb.transform.position = new Vector3((2*x)+playerx, (2*y)+playery,playerz);
    }
}
