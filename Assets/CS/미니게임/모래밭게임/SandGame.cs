using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandGame : MonoBehaviour
{
    private float Null_Num = 0; // ��� ��ǥ ����
    public int SetActive_Num = 0;

    [Header("�ܾ��")]
    public int Obj_Num; // ������Ʈ �� , target_POS�� ������ �ʵ��� �� ����

    [Header("�ܾ� ����")]
    public int[] ward; // ������ �ٲ���� �� ������Ʈ�� ����� ������
    public bool[] cheak; // ��� Ȯ�ο�

    public GameObject[] GameObject; //������Ʈ
    public GameObject[] Sand_Sand; // ��ġ�� �𷡼�
    public GameObject[] target; // ��ĭ
    Vector2[] target_POS = new Vector2[5];

    void Start()
    {
        Null_Num = Screen.height / 5.6f; //ȭ�� ������ ����ؼ� ������ �ٲ�� ����

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
                { Debug.Log("Ŭ����"); }
                break;

            case 3:
                if (cheak[0] == true && cheak[1] == true && cheak[2] == true)
                { Debug.Log("Ŭ����"); }
                break;

            case 4:
                if (cheak[0] == true && cheak[1] == true && cheak[2] == true && cheak[3] == true)
                { Debug.Log("Ŭ����"); }
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
            Debug.Log("Ŭ����!");
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
        // ������Ʈ(GameObject)�� ��ĭ��ǥ(target)�� ward[n]�������� �Ÿ��� Null_Num���� �۴ٸ� true �ִٸ� false
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