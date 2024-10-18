using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshProUGUI를 사용하기 위한 네임스페이스 추가

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    TextMeshProUGUI distance; // TextMeshProUGUI로 변경

    // Start is called before the first frame update
    void Start()
    {
        // car, flag 오브젝트 찾기
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");

        // distance 오브젝트의 TextMeshProUGUI 컴포넌트 가져오기
        this.distance = GameObject.Find("Distance").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // float 자료형 오타 수정
        float length = this.flag.transform.position.x - this.car.transform.position.x;

        // distance 텍스트 업데이트
        this.distance.text = "Distance: " + length.ToString("F2") + "m";
    }
}
