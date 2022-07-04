using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBallController : MonoBehaviour
{
    private Rigidbody ballRd;
    public float speed = 10.0f;

    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody>();
        ballRd.AddForce(Random.Range(-400.0f, 400.0f), 0, speed);

        startPos = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)  //  collision은 출동 object (collision은 벽을 의미)
    {
        //  공이 벽에 충돌하면
        if(collision.gameObject.CompareTag("WALL"))
        {
            Vector3 currPos = transform.position;
            Vector3 incomVec = currPos - startPos;             //  입사각
            Vector3 normalVec = collision.contacts[0].normal;  //  수직벡터
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);

            reflectVec = reflectVec.normalized;  //  반사각 정규화

            ballRd.AddForce(reflectVec * speed);
        }

        startPos = transform.position;
    }
}
