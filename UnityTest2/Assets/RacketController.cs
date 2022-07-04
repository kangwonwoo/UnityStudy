using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketController : MonoBehaviour
{
    private Rigidbody racketRd;
    public float speed = 10.0f;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        racketRd = GetComponent<Rigidbody>();

        startPos = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            //  Rigidbody ���������� �̿��� �̵�
            //racketRd.AddForce(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);

            //  Rigidbody ���������� �̿��� �̵�
            //racketRd.AddForce(+speed, 0, 0);
        }
    }

    /*
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BALL"))
        {
            Vector3 currPos = collision.transform.position;
            Vector3 incomVec = currPos - startPos;
            Vector3 normalVec = collision.contacts[0].normal;
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);

            reflectVec = reflectVec.normalized;

            collision.gameObject.GetComponent<Rigid.AddForce(reflectVec * speed);
        }
        startPos = transform.position;
    }
    */
}
