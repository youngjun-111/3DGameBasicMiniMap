using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    //이값이 트루면 타겟의 좌표 펄스면 현재 좌표를 그대로 사용하기 위한 변수
    [SerializeField] bool x, y, z;

    //쫗아가야할 대상
    [SerializeField] Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!target) return;

        transform.position = new Vector3
            ((x ? target.position.x : transform.position.x),
            (y ? target.position.y : transform.position.y),
            (z ? target.position.z : transform.position.z));
    }
}
