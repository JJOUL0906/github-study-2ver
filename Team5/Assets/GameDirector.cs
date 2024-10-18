using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshProUGUI를 사용하기 위한 네임스페이스 추가

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance; // TextMeshProUGUI가 붙은 오브젝트

    // Start is called before the first frame update
    void Start()
    {
        // car, flag, distance 오브젝트 찾기
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        // float 자료형 오타 수정
        float length = this.flag.transform.position.x - this.car.transform.position.x;

        // TextMeshProUGUI 오타 수정
        this.distance.GetComponent<TextMeshProUGUI>().text = "Distance: " + length.ToString("F2") + "m";
    }
}
