using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2Controller : MonoBehaviour
{
    GameObject player;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //  적의 총구를 Player의 방향으로 조준하기 위해 Rotation 변경
        dir = player.transform.position - this.transform.position;
        this.transform.rotation = Quaternion.LookRotation(dir);
    }
}
