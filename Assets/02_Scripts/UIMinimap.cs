using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMinimap : MonoBehaviour
{
    [SerializeField] Camera minimapCamera;
    [SerializeField] float zoomMin = 1;//카메라의 최소크기 orthographicSize
    [SerializeField] float zoomMax = 30;//카메라의 최대크기 orthographicSize
    [SerializeField] float zoomOneStep = 1;//1 회 줌할 때 증가 / 감소수치
    [SerializeField] Text textMapName;

    private void Awake()
    {
        //맵 이름을 현재 씬 이름으로 설정
        textMapName.text = SceneManager.GetActiveScene().name;
    }


    public void ZoomIn()
    {
        //카메라의 오소그래픽사이즈 값을 감소시켜 카메라에 보이는 사물 크기 확대
        minimapCamera.orthographicSize = Mathf.Max(minimapCamera.orthographicSize + zoomOneStep, zoomMin);
    }

    public void ZoomOut()
    {
        //카메라의 오소그래픽사이즈 값을 증가시켜 카메라에 보이는 사물 크기 축소
        minimapCamera.orthographicSize = Mathf.Min(minimapCamera.orthographicSize - zoomOneStep, zoomMax);
    }
}
