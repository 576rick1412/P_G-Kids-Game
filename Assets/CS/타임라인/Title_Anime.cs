using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Title_Anime : MonoBehaviour
{
    public PlayableDirector PlayableDirector;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.anyKeyDown)
        {
            PlayableDirector.gameObject.SetActive(true);
            PlayableDirector.Play();
        }
    }
}
