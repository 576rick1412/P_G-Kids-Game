using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleClearCheck : MonoBehaviour
{
    public GameObject clearART;
    void Start()
    {
        clearART.SetActive(false);
    }

    void Update()
    {
        PuzzleCon check1 = GameObject.Find("1���ڸ�").GetComponent<PuzzleCon>();
        PuzzleCon check2 = GameObject.Find("2���ڸ�").GetComponent<PuzzleCon>();
        PuzzleCon check3 = GameObject.Find("3���ڸ�").GetComponent<PuzzleCon>();
        PuzzleCon check4 = GameObject.Find("4���ڸ�").GetComponent<PuzzleCon>();

        if(check1.cheak_Clear == true && 
           check2.cheak_Clear == true &&
           check3.cheak_Clear == true &&
           check4.cheak_Clear == true)
        {
            clearART.SetActive(true);
            Debug.Log("Ŭ����");
        }
    }
}
