using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    //�̰��� Ʈ��� Ÿ���� ��ǥ �޽��� ���� ��ǥ�� �״�� ����ϱ� ���� ����
    [SerializeField] bool x, y, z;

    //�m�ư����� ���
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
