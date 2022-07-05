using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10.0f;
    GameObject player;
    // private Rigidbody bulletRd;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShootToEnemy()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, speed));
    }

    public void ShootToPlayer()
    {
        player = GameObject.Find("Player");

        Vector3 dir = player.transform.position - this.transform.position;
        GetComponent<Rigidbody>().AddForce(dir * speed/10);
    }


    public void OnCollisionEnter(Collision coll)
    {
        if(coll.collider.tag == "ENEMY" || coll.collider.tag == "TARGET")
        {
            //  UI Ä«¿îÅÍ +1
            GameObject manager = GameObject.Find("ScoreManager");
            manager.GetComponent<ScoreScript>().IncScore();

            //  ÃÑ¾Ë ÆÄ±«
            Destroy(gameObject);
        }

        
    }
}
