using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medical_Manager : MonoBehaviour
{
    [SerializeField]
    private float Null_Num = 0; // 드롭 좌표 범위

    public int Medical_Num = 0; //성공한 알약수

    public GameObject[] Medical;
    public GameObject[] Medical_Black;

    public GameObject[] setMedical;

    [Header("단어수")]
    Vector2[] Medicalpos = new Vector2[5];

    void Start()
    {
        Null_Num = Screen.height / 12f;

        for (int i = 0; i < Medical.Length; i++)
        {
            Medicalpos[i] = Medical[i].transform.position;
        }

        for(int i = 0; i < setMedical.Length; i++)
        {
            setMedical[i].SetActive(false);
        }
    }

    void Update()
    {
        switch(Medical_Num)
        {
            case 1:
                setMedical[0].SetActive(true);
                break;
            case 2:
                setMedical[1].SetActive(true);
                break;
            case 3:
                setMedical[2].SetActive(true);
                break;
            case 4:
                setMedical[3].SetActive(true);
                break;
            case 5:
                setMedical[4].SetActive(true);
                break;

        }
    }

    public void DragMedical_0()
    {
        DragMedical(0);
    }
    public void DragMedical_1()
    {
        DragMedical(1);
    }
    public void DragMedical_2()
    {
        DragMedical(2);
    }
    public void DragMedical_3()
    {
        DragMedical(3);
    }
    public void DragMedical_4()
    {
        DragMedical(4);
    }

    // =====================================================================

    public void DropMedical_0()
    {
        DropMedical(0);
    }
    public void DropMedical_1()
    {
        DropMedical(1);
    }
    public void DropMedical_2()
    {
        DropMedical(2);
    }
    public void DropMedical_3()
    {
        DropMedical(3);
    }
    public void DropMedical_4()
    {
        DropMedical(4);
    }
    public void DragMedical(int x)
    {
        Medical[x].transform.position = Input.mousePosition;
    }

    public void DropMedical(int i)
    {
        for (int j = 0; j < 5; j++)
        {
            // 알약(Medical)과 약접시좌표(Medical_Black)의 거리가 Null_Num보다 작다면 true 멀다면 false
            float Distance0 = Vector3.Distance(Medical[i].transform.position, Medical_Black[j].transform.position);
            if (Distance0 < Null_Num)
            { Medical[i].SetActive(false); Medical_Num++; return; }
        }
        Medical[i].transform.position = Medicalpos[i];
    }
}