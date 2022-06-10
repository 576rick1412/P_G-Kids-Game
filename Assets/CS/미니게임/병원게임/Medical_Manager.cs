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

    Vector2 Medicalpos_0;
    Vector2 Medicalpos_1;
    Vector2 Medicalpos_2;
    Vector2 Medicalpos_3;
    Vector2 Medicalpos_4;

    void Start()
    {
        Null_Num = Screen.height / 12f;

        if (Medical.Length == 2)
        {
            Medicalpos_0 = Medical[0].transform.position;
            Medicalpos_1 = Medical[1].transform.position;
        }

        if (Medical.Length == 3)
        {
            Medicalpos_0 = Medical[0].transform.position;
            Medicalpos_1 = Medical[1].transform.position;
            Medicalpos_2 = Medical[2].transform.position;
        }

        if (Medical.Length == 5)
        {
            Medicalpos_0 = Medical[0].transform.position;
            Medicalpos_1 = Medical[1].transform.position;
            Medicalpos_2 = Medical[2].transform.position;
            Medicalpos_3 = Medical[3].transform.position;
            Medicalpos_4 = Medical[4].transform.position;
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
        Medical[0].transform.position = Input.mousePosition;
    }
    public void DragMedical_1()
    {
        Medical[1].transform.position = Input.mousePosition;
    }
    public void DragMedical_2()
    {
        Medical[2].transform.position = Input.mousePosition;
    }
    public void DragMedical_3()
    {
        Medical[3].transform.position = Input.mousePosition;
    }
    public void DragMedical_4()
    {
        Medical[4].transform.position = Input.mousePosition;
    }
    // =====================================================================
    public void DropMedical_0()
    {
        int i = 0;

        for (int j = 0; j < 5; j++)
        {
            // 알약(Medical)과 약접시좌표(Medical_Black)의 거리가 Null_Num보다 작다면 true 멀다면 false
            float Distance0 = Vector3.Distance(Medical[i].transform.position, Medical_Black[j].transform.position);
            if (Distance0 < Null_Num)
            { Medical[i].SetActive(false); Medical_Num++; return; }
        }
        Medical[i].transform.position = Medicalpos_0;
    }
    public void DropMedical_1()
    {
        int i = 1;

        for (int j = 0; j < 5; j++)
        {
            float Distance0 = Vector3.Distance(Medical[i].transform.position, Medical_Black[j].transform.position);
            if (Distance0 < Null_Num)
            { Medical[i].SetActive(false); Medical_Num++; return; }
        }
        Medical[i].transform.position = Medicalpos_1;
    }
    public void DropMedical_2()
    {
        int i = 2;

        for (int j = 0; j < 5; j++)
        {
            float Distance0 = Vector3.Distance(Medical[i].transform.position, Medical_Black[j].transform.position);
            if (Distance0 < Null_Num)
            { Medical[i].SetActive(false); Medical_Num++; return; }
        }
        Medical[i].transform.position = Medicalpos_2;
    }
    public void DropMedical_3()
    {
        int i = 3;

        for (int j = 0; j < 5; j++)
        {
            float Distance0 = Vector3.Distance(Medical[i].transform.position, Medical_Black[j].transform.position);
            if (Distance0 < Null_Num)
            { Medical[i].SetActive(false); Medical_Num++; return; }
        }
        Medical[i].transform.position = Medicalpos_3;
    }
    public void DropMedical_4()
    {
        int i = 4;

        for (int j = 0; j < 5; j++)
        {
            float Distance0 = Vector3.Distance(Medical[i].transform.position, Medical_Black[j].transform.position);
            if (Distance0 < Null_Num)
            { Medical[i].SetActive(false); Medical_Num++; return; }
        }
        Medical[i].transform.position = Medicalpos_4;
    }
}