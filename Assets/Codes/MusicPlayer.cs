using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource audios;
    public AudioClip day, night;
    // Start is called before the first frame update
    void Start()
    {
        //busca script de dia e noite no jogo
        DayCicle dayscript = GameObject.FindObjectOfType<DayCicle>();
        //inscreve as funcoes nos eventos de dia e noite
        dayscript.myNightCall += PlayNight;
        dayscript.myMorningCall += PlayDay;
    }

    void PlayDay()
    {
        audios.clip = day;
        audios.Play();
    }

    void PlayNight()
    {
        audios.clip = night;
        audios.Play();
    }
}
