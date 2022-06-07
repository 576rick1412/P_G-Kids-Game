using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Move : MonoBehaviour
{
    public void Go_MedicGame_Hub()
    {
        SceneManager.LoadScene("MedicGame_Hub");
    }

    public void Go_AppleGame_Hub()
    {
        SceneManager.LoadScene("AppleGame_Hub");
    }

    public void Go_PuzzleGame_Hub()
    {
        SceneManager.LoadScene("PuzzleGame_Hub");
    }

    public void Go_AnimalGame_Hub()
    {
        SceneManager.LoadScene("AnimalGame_Hub");
    }
}
