using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PuzzleCon : MonoBehaviour
{
    public int a;
    public Sprite[] Puzzle;

    public Image Image;
    public bool cheak_Clear = false;

    void Start()
    {
        Image.sprite = Puzzle[a];
        if(a == 0) cheak_Clear = true;
    }

    public void PuzzleCheck()
    {
        if (a > 2)
        {
            a = 0;
            cheak_Clear = true;
        }
        else
        {
            cheak_Clear = false;
            a++;
        }
        Image.sprite = Puzzle[a];
    }
}


