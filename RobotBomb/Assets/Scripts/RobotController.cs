using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    Rigidbody2D robotRD;
    public float walkSpeed = 10.0f;
    public float jumpSpeed = 10.0f;

    Animator animator;
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        robotRD = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isMoving = false;

            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -8.0f)
            {
                isMoving = true;

                //  walk 애니메이션 시작
                animator.SetBool("isWalking", true);

                //  왼쪾 이동
                transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
                //robotRD.AddForce(transform.right * -walkSpeed);

                //  뒤돌기
                transform.localScale = new Vector2(-2.0f, 2.0f);
            }

            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 8.0f)
            {
                isMoving = true;

                //  walk 애니메이션 시작
                animator.SetBool("isWalking", true);

                //  오른쪽 이동
                transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
                //robotRD.AddForce(transform.right * walkSpeed);

                //  뒤돌기
                transform.localScale = new Vector2(+2.0f, 2.0f);
            }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //  Jump 애니메이션 시작
            animator.SetTrigger("jumpTrigger");

            //  점프
            //transform.Translate(Vector2.up * jumpSpeed * Time.deltaTime);
            robotRD.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
        }

        if (!isMoving)
            {
                //  walk 애니메이션 종료
                animator.SetBool("isWalking", false);
            }
    }
}
