using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_Button : MonoBehaviour
{
    public void Hub_Scene()
    {
        SceneManager.LoadScene("Main_Scene");
    }
    public void PuzzleGame_Scene()
    {
        SceneManager.LoadScene("PuzzleGame_Hub");
    }

    public void MedicGame_Scene()
    {
        SceneManager.LoadScene("MedicGame_Hub");
    }

    public void AniamlGame_Scene()
    {
        SceneManager.LoadScene("AnimalGame_Hub");
    }

    public void AppleGame_Scene()
    {
        SceneManager.LoadScene("AppleGame_Hub");
    }

    public void Main_Scene()
    {
        SceneManager.LoadScene("Title_Scene");
    }
}
