using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankController : MonoBehaviour
{
    public ParticleSystem targetExplosion;

    float mvSpeed = 10.0f;
    float roSpeed = 150.0f;
    private Text score1;
    private Text score2;

    public int playerNum = 1;  //  탱크 번호
    private string mvAxisName;  //  이동축 이름(Vertical1, Vertical2)
    private string roAxisName;  //  회전축 이름(Horizontal1, Horizontal2)


    // Start is called before the first frame update
    void Start()
    {
        mvAxisName = "Vertical" + playerNum;
        roAxisName = "Horizontal" + playerNum;
    }

    // Update is called once per frame
    void Update()
    {
        float mv = Input.GetAxis(mvAxisName) * mvSpeed * Time.deltaTime;
        float ro = Input.GetAxis(roAxisName) * roSpeed * Time.deltaTime;

        transform.Translate(0, 0, mv);
        transform.Rotate(0, ro, 0);
    }

    public void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "SHELL")
        {
            this.score1 = GameObject.Find("Score1").GetComponent<Text>();
            this.score2 = GameObject.Find("Score2").GetComponent<Text>();

            if (score1.text == "3")
            {
                ParticleSystem fire = Instantiate(targetExplosion, transform.position, transform.rotation);
                fire.Play();

                Destroy(gameObject);
            }

            if (score2.text == "3")
            {
                ParticleSystem fire = Instantiate(targetExplosion, transform.position, transform.rotation);
                fire.Play();

                Destroy(gameObject);
            }
        }
    }
}
