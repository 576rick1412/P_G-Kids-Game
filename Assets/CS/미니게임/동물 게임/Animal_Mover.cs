using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal_Mover : MonoBehaviour
{
    private float Null_Num = 0;

    [Header("단어수")]
    public int Ward_Num;

    [Header("단어 순서")]
    public int[] ward;
    public bool[] cheak;

    public GameObject[] GameObject;
    public GameObject[] target;
    Vector2[] target_POS = new Vector2[5];

    void Start()
    {
        Null_Num = Screen.height / 5f;

        for (int i = 0; i < Ward_Num; i++)
        {
            target_POS[i] = GameObject[i].transform.position;
        }

        for(int i = 0; i < cheak.Length; i++)
        {
            cheak[i] = false;
        }

    }

    void Update()
    {
        switch(cheak.Length)
        {
            case 2:
                if (cheak[0] == true && cheak[1] == true)
                {Debug.Log("클리어");}
                break;

            case 3:
                if (cheak[0] == true && cheak[1] == true && cheak[2] == true)
                {Debug.Log("클리어");}
                break;

            case 4:
                if (cheak[0] == true && cheak[1] == true && cheak[2] == true && cheak[3] == true)
                {Debug.Log("클리어");}
                break;
        }
    }

    public void DragAnimal_0()
    {
        GameObject[0].transform.position = Input.mousePosition;
        cheak[0] = false;
    }
    public void DragAnimal_1()
    {
        GameObject[1].transform.position = Input.mousePosition;
        cheak[1] = false;
    }
    public void DragAnimal_2()
    {
        GameObject[2].transform.position = Input.mousePosition;
        cheak[2] = false;
    }
    public void DragAnimal_3()
    {
        GameObject[3].transform.position = Input.mousePosition;
        cheak[3] = false;
    }
    public void DragAnimal_4()
    {
        GameObject[4].transform.position = Input.mousePosition;
        cheak[4] = false;
    }
    // =====================================================================
    public void DropAnimal_0()
    {
        float Distance = Vector3.Distance(GameObject[0].transform.position, target[ward[0]].transform.position);
        if (Distance < Null_Num)
        {
            GameObject[0].transform.position = target[ward[0]].transform.position;
            cheak[0] = true;
        }
        else
        {
            GameObject[0].transform.position = target_POS[0];
        }
    }
    public void DropAnimal_1()
    {
        float Distance = Vector3.Distance(GameObject[1].transform.position, target[ward[1]].transform.position);
        if (Distance < Null_Num)
        {
            GameObject[1].transform.position = target[ward[1]].transform.position;
            cheak[1] = true;
        }
        else
        {
            GameObject[1].transform.position = target_POS[1];
        }
    }
    public void DropAnimal_2()
    {
        float Distance = Vector3.Distance(GameObject[2].transform.position, target[ward[2]].transform.position);
        if (Distance < Null_Num)
        {
            GameObject[2].transform.position = target[ward[2]].transform.position;
            cheak[2] = true;
        }
        else
        {
            GameObject[2].transform.position = target_POS[2];
        }
    }
    public void DropAnimal_3()
    {
        float Distance = Vector3.Distance(GameObject[3].transform.position, target[ward[3]].transform.position);
        if (Distance < Null_Num)
        {
            GameObject[3].transform.position = target[ward[3]].transform.position;
            cheak[3] = true;
        }
        else
        {
            GameObject[3].transform.position = target_POS[3];
        }
    }
    public void DropAnimal_4()
    {
        float Distance = Vector3.Distance(GameObject[4].transform.position, target[ward[4]].transform.position);
        if (Distance < Null_Num)
        {
            GameObject[4].transform.position = target[ward[4]].transform.position;
            cheak[4] = true;
        }
        else
        {
            GameObject[4].transform.position = target_POS[4];
        }
    }
}
