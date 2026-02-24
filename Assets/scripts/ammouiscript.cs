using UnityEngine;

public class ammouiscript : MonoBehaviour
{
    public GameObject go,player;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        player pscript = player.GetComponent<player>();
        if (pscript.alive == false )
        {
            go.SetActive( false );
        }
    }
}
