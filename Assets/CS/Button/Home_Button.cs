using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Home_Button : MonoBehaviour
{
    public void goHome()
    {
        SceneManager.LoadScene("Title_Scene");
    }
}
