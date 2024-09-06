using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMinimap : MonoBehaviour
{
    [SerializeField] Camera minimapCamera;
    [SerializeField] float zoomMin = 1;//ī�޶��� �ּ�ũ�� orthographicSize
    [SerializeField] float zoomMax = 30;//ī�޶��� �ִ�ũ�� orthographicSize
    [SerializeField] float zoomOneStep = 1;//1 ȸ ���� �� ���� / ���Ҽ�ġ
    [SerializeField] Text textMapName;

    private void Awake()
    {
        //�� �̸��� ���� �� �̸����� ����
        textMapName.text = SceneManager.GetActiveScene().name;
    }


    public void ZoomIn()
    {
        //ī�޶��� ���ұ׷��Ȼ����� ���� ���ҽ��� ī�޶� ���̴� �繰 ũ�� Ȯ��
        minimapCamera.orthographicSize = Mathf.Max(minimapCamera.orthographicSize + zoomOneStep, zoomMin);
    }

    public void ZoomOut()
    {
        //ī�޶��� ���ұ׷��Ȼ����� ���� �������� ī�޶� ���̴� �繰 ũ�� ���
        minimapCamera.orthographicSize = Mathf.Min(minimapCamera.orthographicSize - zoomOneStep, zoomMax);
    }
}
