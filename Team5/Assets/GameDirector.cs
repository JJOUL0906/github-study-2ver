using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshProUGUI�� ����ϱ� ���� ���ӽ����̽� �߰�

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    TextMeshProUGUI distance; // TextMeshProUGUI�� ����

    // Start is called before the first frame update
    void Start()
    {
        // car, flag ������Ʈ ã��
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");

        // distance ������Ʈ�� TextMeshProUGUI ������Ʈ ��������
        this.distance = GameObject.Find("Distance").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // float �ڷ��� ��Ÿ ����
        float length = this.flag.transform.position.x - this.car.transform.position.x;

        // distance �ؽ�Ʈ ������Ʈ
        this.distance.text = "Distance: " + length.ToString("F2") + "m";
    }
}
