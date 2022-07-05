using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 1.0f;

    private float x;
    private float length = 2.0f;
    private float timeAfterMove;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeAfterMove += TimeAfterMove.deltaTime;
        x = Mathf.Sin(timeAfterMove) * length;

        transform.position = new Vector3(x * speed, transform.position.y, transform.position.z)

        /*
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.MoveRate * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.MoveRate * speed * Time.deltaTime);
        }
        */
    }
}
