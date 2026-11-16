using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
        public static AudioManager Instance;
public AudioSource musicSource;
public AudioSource sfxSource;   
    public AudioClip overworldMusic; 
    public AudioClip caveMusic;      

    public AudioClip[] variousSFX;

    void Start()
    {
          musicSource.clip = overworldMusic;

    musicSource.Play();

    }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        
         } else
        
            Destroy(gameObject);
        
    }
    public void PlayMusicSFX(AudioClip clip){
    sfxSource.clip = clip;
    sfxSource.Play();
}
public void PlayMusic(AudioClip clip)
{
    musicSource.clip = clip;
    musicSource.Play();
}
public void PlayRandomSFX(params AudioClip[] clips)
{
    variousSFX =clips;
    int randomIndex = Random.Range(0, variousSFX.Length);
    sfxSource.PlayOneShot(variousSFX[randomIndex]);




}

    // Update is called once per frame
    void Update()
    {
        
    }
}
