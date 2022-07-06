using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{
    public ParticleSystem shellExplosion;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision coll)
    {
        ParticleSystem fire = Instantiate(shellExplosion, transform.position, transform.rotation);
        fire.Play();  //  ÀÌÇÈÆ® Àç»ý

        float DestroyTime = 10.0f;

        if(coll.collider.tag == "PLANE")
        {
            Destroy(gameObject, DestroyTime);
            Destroy(fire.gameObject);
        }

        if (coll.collider.name == "Tank")
        {
            // UI Ä«¿îÅÍ +1
            GameObject manager = GameObject.Find("ScoreManager");
            manager.GetComponent<ScoreScript>().IncScore2();

            // ÃÑ¾Ë ÆÄ±«
            Destroy(gameObject);
        }

        if (coll.collider.name == "Tank2")
        {
            // UI Ä«¿îÅÍ +1
            GameObject manager = GameObject.Find("ScoreManager");
            manager.GetComponent<ScoreScript>().IncScore1();

            // ÃÑ¾Ë ÆÄ±«
            Destroy(gameObject);
        }
    }
}
