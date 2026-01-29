using System.Collections;
using System.Threading;
using UnityEngine;

public class weapon : MonoBehaviour
{
    
    public int capacity,reloadtime;
    int ammo;
    bool reload;
    Ray2D ray;
    public Rigidbody2D player,gun,weaponpng,pistolsonu;
    IEnumerator Bekle()
    {
        print("bekle");
        yield return new WaitForSeconds(reloadtime);
        print("bekleme bitti");
        reload = false;
        ammo = capacity;
    }
    void Start()
    {
        ammo = capacity;   
    }

    void Update()
    {
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        /*Vector3 direction = mousepos - player.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        gun.transform.rotation = Quaternion.Euler(new Vector3(0, 0,angle));
        gun.transform.position = player.transform.position + Quaternion.Euler(0, 0, angle) * new Vector3(0.4f, 0, 0);*/
        ray = new Ray2D(player.transform.position,mousepos);
        //Debug.DrawLine(player.transform.position, mousepos);
        //Debug.Log(ray.direction);
        if (gun.transform.position.x - player.transform.position.x > 0)
        {
            weaponpng.transform.localScale = new Vector3(0.3f,-0.3f,0.3f);
        }
        else
        {
            weaponpng.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }

        gun.transform.right = -ray.direction;
        //gun.transform.rotation = new Quaternion(ray.direction.x,0,0,0);
        gun.transform.position = new Vector2(player.position.x + ray.direction.normalized.x*0.4f,player.position.y + ray.direction.normalized.y*0.4f);
        /*float angle = Mathf.Atan2(ray.direction.normalized.y,ray.direction.normalized.x)* Mathf.Rad2Deg;
        gun.transform.eulerAngles = new Vector3(0,0,angle);*/
        RaycastHit2D raycast = Physics2D.Raycast(pistolsonu.transform.position,mousepos);
        Debug.DrawLine(pistolsonu.transform.position,mousepos);

        if (Input.GetKeyDown(KeyCode.R) || ammo == 0)
        {
            reload = true;
            StartCoroutine(Bekle());
        }
        if(Input.GetMouseButtonDown(0) && reload == true){ print("reloaddayken ates ettin"); }
        if (Input.GetMouseButtonDown(0) && reload == false)
        {
            ammo--;
            print(ammo);
            if (raycast && /*raycast.transform.gameObject.tag == "zombi" &&*/ reload == false)
            {
                raycast.transform.gameObject.SetActive(false);
                print(raycast.transform.gameObject.tag);
            }
        }
        

    }
}
