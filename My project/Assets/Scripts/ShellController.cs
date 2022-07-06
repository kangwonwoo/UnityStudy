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
        fire.Play();  //  ����Ʈ ���

        float DestroyTime = 10.0f;

        if(coll.collider.tag == "PLANE")
        {
            Destroy(gameObject, DestroyTime);
            Destroy(fire.gameObject);
        }

        if (coll.collider.name == "Tank")
        {
            // UI ī���� +1
            GameObject manager = GameObject.Find("ScoreManager");
            manager.GetComponent<ScoreScript>().IncScore2();

            // �Ѿ� �ı�
            Destroy(gameObject);
        }

        if (coll.collider.name == "Tank2")
        {
            // UI ī���� +1
            GameObject manager = GameObject.Find("ScoreManager");
            manager.GetComponent<ScoreScript>().IncScore1();

            // �Ѿ� �ı�
            Destroy(gameObject);
        }
    }
}
