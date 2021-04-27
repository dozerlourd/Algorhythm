using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoving : MonoBehaviour
{
    GameObject cube;
    float speed;
    Vector3 moveDir = Vector3.up;

    // Update is called once per frame
    void Update()
    {
        //계속 반복
        MoveCube();
        ChangeDirection();
    }

    void MoveCube()
    {
        if (cube.transform.position.y > 10)
        {
            speed = -1;
        }
        else if(cube.transform.position.y < -10)
        {
            speed = 1;
        }

        cube.transform.Translate(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
    }

    void ChangeDirection()
    {
        //큐브의 y좌표가 10보다 커지면 이동 방향을 아래로 바꾼다.
        if (cube.transform.position.y > 10)
        {
            moveDir = Vector3.down;
        }
        //큐브의 y좌표가 -10보다 낮으면 이동 방향을 위로 바꾼다.
        else if(cube.transform.position.y < -10)
        {
            moveDir = Vector3.up;
        }

        //특정 방향으로 이동
        cube.transform.Translate(moveDir);
    }
}
