using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
public class Play_Button : MonoBehaviour
{
    public PlayableDirector LOGO_Anime; //타임라인 불러오기

    void Update()
    {
     if(Input.anyKey)
        {
            LOGO_Anime.gameObject.SetActive(true);
            LOGO_Anime.Play();
            Invoke("late_b", 1.1f);
        }
    }
    public void play_b()
    {
        LOGO_Anime.gameObject.SetActive(true);
        LOGO_Anime.Play();
        Invoke("late_b", 1.5f);
    }

    private void late_b()
    {
        SceneManager.LoadScene("Main_Scene");
    }
}
