using UnityEngine;

public class spritechanger : MonoBehaviour
{
    float t;
    int a = 0;
    public float x;
    public Sprite sprite1, sprite2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t = t + Time.deltaTime;
        var _time = (int)Time.time;
        if (t > x && a == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
            t = 0;
            a = 1;
        }
        else if (t > x && a == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
            t = 0;
            a = 0;
        }
    }
}
