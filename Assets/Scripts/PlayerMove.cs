using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        print("h: " + h + "v: " + v);

        Vector3 dir = new Vector3(h, v, 0);
        //transform.Translate(dir * speed * Time.deltaTime); 이 코드를 직접 만들 줄 알아야함
        transform.position +=  dir * speed * Time.deltaTime; // 이동식은 현재위치 + 방향 * 속도 * 시간

    }
}
