using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Internal;


[RequireComponent(typeof(AudioSource))]
public class Audio_ : MonoBehaviour
{
    public enum mode
    {
        Constant,
        PlayOnce,
        PlayEvery
    }

    [Header("You can only play one of each kind of audio")]
    [Header("Add the audio clip .mp3 or .wav")]
    public List<AudioClip> audios = new List<AudioClip>();
    [Header("Constant, PlayOnce when player is near, Play Every seconds")]
    public List<mode> audioMode = new List<mode>();
    [Header("Default value should be 2")]
    public List<float> audioDistance = new List<float>();
    [Header("How many seconds between each play")]
    public List<float> audioSeconds = new List<float>();


    private int constantAudio;
    private int playedOnceInt;
    private bool playedOnceBool;
    //private List<int> playEveryPostion;
    private float timer;

    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //_audioSource = GetComponent<AudioSource>();
        //AudioSet();
    }

    // Update is called once per frame
    void Update()
    {
        /*timer += Time.deltaTime;
        
        if (playedOnceBool)
        {
            PlayOnce();
        }

        if (!playedOnceBool)
        {
            BackToConstant();
        }

        PlayEvery(timer);*/
    }

    void AudioSet()
    {
        _audioSource.spatialBlend = 1f;
        _audioSource.minDistance = 0.01f;
        if (audios != null)
        {
            for (int i = 0; i < audios.Count; i++)
            {
                //CONSTANT
                if (audioMode[i] == mode.Constant)
                {
                    if (_audioSource.loop == false)
                    {
                        constantAudio = i;
                        _audioSource.clip = audios[i];
                        _audioSource.loop = true;
                        _audioSource.maxDistance = audioDistance[i];
                        _audioSource.Play();
                    }
                    else
                    {
                        Debug.Log("THERE ARE MORE THEN 2 CONSTANT SOUNDS");
                    }
                }

                //PLAYED_ONCE
                if (audioMode[i] == mode.PlayOnce)
                {
                    playedOnceInt = i;
                    playedOnceBool = true;
                }

                ////PLAYED_EVERY
                //if (audioMode[i] == mode.PlayEvery)
                //{
                //    playEveryPostion.Add(i);
                //}
            }
        }
    }

    void PlayOnce()
    {
        Vector3 playerPos = GameObject.Find("FPSController 1(Clone)").gameObject.transform.position;
        Vector3 objectPos = transform.position;

        if (objectPos.x - playerPos.x < 3f && objectPos.x - playerPos.x > 3f &&
            objectPos.z - playerPos.z < 3f && objectPos.z - playerPos.z > 3f)
        {
            _audioSource.clip = audios[playedOnceInt];
            _audioSource.loop = false;
            _audioSource.maxDistance = audioDistance[playedOnceInt];
            _audioSource.Play();
        }

        playedOnceBool = false;
    }

    void BackToConstant()
    {
        if (!_audioSource.isPlaying)
        {
            _audioSource.clip = audios[constantAudio];
            _audioSource.loop = true;
            _audioSource.maxDistance = audioDistance[constantAudio];
            _audioSource.Play();
        }
    }

    void PlayEvery(float timer)
    {
        for (int i = 0; i < audioSeconds.Count; i++)
        {
            if (audioSeconds[i] != 0f)
            {
                if (audioSeconds[i] % timer < 0.5f || audioSeconds[i] % timer > -0.5f)
                {
                    _audioSource.clip = audios[i];
                    _audioSource.loop = false;
                    _audioSource.maxDistance = audioDistance[i];
                    _audioSource.Play();
                }
            }
        }
    }
}
