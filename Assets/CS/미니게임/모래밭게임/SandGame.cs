using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandGame : MonoBehaviour
{
    public GameObject[] Medical;
    public GameObject[] Medical_Black;
    Vector2[] Medicalpos;

    void Start()
    {
        Medicalpos[0] = Medical[0].transform.position;
        Medicalpos[1] = Medical[1].transform.position;
        Medicalpos[2] = Medical[2].transform.position;
        Medicalpos[3] = Medical[3].transform.position;
        Medicalpos[4] = Medical[4].transform.position;
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
        float Distance = Vector3.Distance(Medical[0].transform.position, Medical_Black[0].transform.position);
        if (Distance < 50)
        {
            Medical[0].transform.position = Medical_Black[0].transform.position;
        }
        else
        {
            Medical[0].transform.position = Medicalpos[0];
        }
    }
    public void DropMedical_1()
    {
        float Distance = Vector3.Distance(Medical[1].transform.position, Medical_Black[1].transform.position);
        if (Distance < 50)
        {
            Medical[1].transform.position = Medical_Black[1].transform.position;
        }
        else
        {
            Medical[1].transform.position = Medicalpos[1];
        }
    }
    public void DropMedical_2()
    {
        float Distance = Vector3.Distance(Medical[2].transform.position, Medical_Black[2].transform.position);
        if (Distance < 50)
        {
            Medical[2].transform.position = Medical_Black[2].transform.position;
        }
        else
        {
            Medical[2].transform.position = Medicalpos[2];
        }
    }
    public void DropMedical_3()
    {
        float Distance = Vector3.Distance(Medical[3].transform.position, Medical_Black[3].transform.position);
        if (Distance < 50)
        {
            Medical[3].transform.position = Medical_Black[3].transform.position;
        }
        else
        {
            Medical[3].transform.position = Medicalpos[3];
        }
    }
    public void DropMedical_4()
    {
        float Distance = Vector3.Distance(Medical[4].transform.position, Medical_Black[4].transform.position);
        if (Distance < 50)
        {
            Medical[4].transform.position = Medical_Black[4].transform.position;
        }
        else
        {
            Medical[4].transform.position = Medicalpos[4];
        }
    }
}