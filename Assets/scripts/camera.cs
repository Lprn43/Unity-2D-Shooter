using Unity.VisualScripting;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Rigidbody2D player;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = player.transform.position.x;
        float y = player.transform.position.y;

        rb.transform.position = new Vector3(x,y,-0.92f);

    }
}
