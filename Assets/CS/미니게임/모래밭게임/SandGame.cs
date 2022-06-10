using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandGame : MonoBehaviour
{
    private float Null_Num = 0; // 드롭 좌표 범위
    public int SetActive_Num = 0;

    [Header("단어수")]
    public int Obj_Num; // 오브젝트 수 , target_POS가 꼬이지 않도록 수 조정

    [Header("단어 순서")]
    public int[] ward; // 순서가 바뀌었을 때 오브젝트가 제대로 가도록
    public bool[] cheak; // 드롭 확인용

    public GameObject[] GameObject; //오브젝트
    public GameObject[] Sand_Sand; // 배치된 모래성
    public GameObject[] target; // 빈칸
    Vector2[] target_POS = new Vector2[5];

    void Start()
    {
        Null_Num = Screen.height / 5.6f; //화면 비율이 비례해서 범위가 바뀌기 위해

        for (int i = 0; i < Obj_Num; i++)
        {
            target_POS[i] = GameObject[i].transform.position;
        }

        for (int i = 0; i < cheak.Length; i++)
        {
            cheak[i] = false;
        }

    }

    void Update()
    {
        switch (cheak.Length)
        {
            case 2:
                if (cheak[0] == true && cheak[1] == true)
                { Debug.Log("클리어"); }
                break;

            case 3:
                if (cheak[0] == true && cheak[1] == true && cheak[2] == true)
                { Debug.Log("클리어"); }
                break;

            case 4:
                if (cheak[0] == true && cheak[1] == true && cheak[2] == true && cheak[3] == true)
                { Debug.Log("클리어"); }
                break;
        }
        
        switch(SetActive_Num)
        {
            case 0:
                GameObject[SetActive_Num].SetActive(true);
                break;
            case 1:
                GameObject[SetActive_Num].SetActive(true);
                clearCheak();
                Sand_Sand[SetActive_Num - 1].SetActive(true);
                break;
            case 2:
                GameObject[SetActive_Num].SetActive(true);
                clearCheak();
                Sand_Sand[SetActive_Num - 1].SetActive(true);
                break;
            case 3:
                GameObject[SetActive_Num].SetActive(true);
                clearCheak();
                Sand_Sand[SetActive_Num - 1].SetActive(true);
                break;
            case 4:
                GameObject[SetActive_Num].SetActive(true);
                clearCheak();
                Sand_Sand[SetActive_Num - 1].SetActive(true);
                break;
        }
    }
    public void clearCheak()
    {
        if(cheak.Length >= SetActive_Num)
        {
            Debug.Log("클리어!");
        }
    }

    public void DragsSand_0()
    {
        DragsSand(0);
    }
    public void DragsSand_1()
    {
        DragsSand(1);
    }
    public void DragsSand_2()
    {
        DragsSand(2);
    }
    public void DragsSand_3()
    {
        DragsSand(3);
    }
    public void DragsSand_4()
    {
        DragsSand(4);
    }

    // =====================================================================
    public void DropSand_0()
    {
        DropSand(0);
    }
    public void DropSand_1()
    {
        DropSand(1);
    }
    public void DropSand_2()
    {
        DropSand(2);
    }
    public void DropSand_3()
    {
        DropSand(3);
    }
    public void DropSand_4()
    {
        DropSand(4);
    }

    public void DragsSand(int i)
    {
        GameObject[i].transform.position = Input.mousePosition;
        cheak[i] = false;
    }

    public void DropSand(int i)
    {
        // 오브젝트(GameObject)와 빈칸좌표(target)의 ward[n]번쨰와의 거리가 Null_Num보다 작다면 true 멀다면 false
        float Distance = Vector3.Distance(GameObject[i].transform.position, target[ward[i]].transform.position);
        if (Distance < Null_Num)
        {
            GameObject[i].transform.position = target[ward[i]].transform.position;
            cheak[i] = true;
            SetActive_Num++;
            Destroy(GameObject[i]);
        }
        else
        {
            GameObject[i].transform.position = target_POS[i];
        }
    }
}