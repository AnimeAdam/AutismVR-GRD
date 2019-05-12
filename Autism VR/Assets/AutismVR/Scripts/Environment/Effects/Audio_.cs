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
    public List<AudioClip> audios = new List<AudioClip>();                          //AUDIO CLIP
    [Header("Constant, PlayOnce when player is near, Play Every seconds")]
    public List<mode> audioMode = new List<mode>();                                 //AUDIO MODE
    [Header("Default value should be 2")]
    public List<float> audioDistance = new List<float>();                           //SET AUDIO DISTANCE
    [Header("How many seconds between each play")]
    public List<float> audioSeconds = new List<float>();                            //SET HOW LONG TO PLAY SOUND BETWEEN CLIPS
    
    //Variables for Audios
    private bool playOnceBool = true;

    //TIMER
    private float timer;

    //Checkers false is 0 for a list
    private bool audioClipCheck = false;
    private bool audioModeCheck = false;
    private bool audioDistanceCheck = false;
    private bool audioSecondsCheck = false;

    //COMPONENTS
    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        AudioDefault();
        AudioSet();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (!_audioSource.isPlaying)
        {
            ResetConstant();
        }

        if (playOnceBool)
        {
            PlayOnceNow();
        }
    }

    #region AudioModes

    void SetConstant()
    {
        for (int i = 0; i < audioMode.Count; i++)
        {
            if (audioMode[i] == mode.Constant)
            {
                if (_audioSource.clip == null)
                {
                    PlayAudio(audios[i], true);
                    SetAudioDistance(i);
                }
                else
                {
                    Debug.Log(gameObject.name + " HAS TWO OR MORE AUDIO CONSTANTS");
                    Debug.Break();
                }
            }
        }
    }

    void ResetConstant()
    {
        for (int i = 0; i < audioMode.Count; i++)
        {
            if (audioMode[i] == mode.Constant)
            {
                PlayAudio(audios[i], true);
                SetAudioDistance(i);
            }
        }
    }

    void PlayOnceNow()
    {
        for (int i = 0; i < audioMode.Count; i++)
        {
            if (audioMode[i] == mode.PlayOnce)
            {
                Vector3 playerPos = GameObject.Find("Main Camera").gameObject.transform.position;
                Vector3 objectPos = transform.position;

                if (audioDistance[i] != 0f)
                {
                    if ((objectPos.x - playerPos.x < audioDistance[i] && objectPos.z - playerPos.z < audioDistance[i]) &&
                        (objectPos.x - playerPos.x > -audioDistance[i] && objectPos.z - playerPos.z > -audioDistance[i]))   
                    {
                        PlayAudio(audios[i]);
                        SetAudioDistance(i);
                        playOnceBool = false;
                    }
                }
                else
                {
                    Debug.Log(gameObject.name + " AUDIO DISTANCE IS MISSING!!!");
                    Debug.Break();
                }
            }
        }
    }

    void PlayEveryTime(float timer)
    {
        for (int i = 0; i < audioMode.Count; i++)
        {
            if (audioMode[i] == mode.PlayEvery)
            {
                if (audioSeconds[i] != 0)
                {
                    if (timer % audioSeconds[i] == 0)
                    {
                        PlayAudio(audios[i]);
                        SetAudioDistance(i);
                    }
                }
                else
                {
                    Debug.Log(gameObject.name + " AUDIO SECONDS HAVEN'T BEEN SET!!!");
                    Debug.Break();
                }
            }
        }
    }

    #endregion

    #region AudioSettings

    void PlayAudio(AudioClip ac, bool loop = false)
    {
        if (loop)
        {
            _audioSource.loop = true;
        }
        else
        {
            _audioSource.loop = false;
        }
        _audioSource.clip = ac;
        _audioSource.Play();
    }

    void SetAudioDistance(int index)
    {
        if (audioDistanceCheck)
        {
            if (audioDistance[index] == 0)
            {
                _audioSource.maxDistance = 2f;
            }
            else
            {
                _audioSource.maxDistance = audioDistance[index];
            }
        }
    }

    #endregion

    #region Defaults

    void AudioDefault()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.playOnAwake = false;
        _audioSource.spatialBlend = 1f;
        _audioSource.minDistance = 0.01f; //0.01f
        _audioSource.maxDistance = 2f;

        if (audios.Count > 0)
        {
            foreach (AudioClip clip in audios)
            {
                if (clip == null)
                {
                    Debug.Log(gameObject.name + " AUDIO CLIP IS MISSING!!!");
                    Debug.Break();
                }
            }
            audioClipCheck = true;
        }
        if (audioMode.Count > 0)
        {
            audioModeCheck = true;
        }
        if (audioDistance.Count > 0)
        {
            audioDistanceCheck = true;
        }
        if (audioSeconds.Count > 0)
        {
            audioSecondsCheck = true;
        }
    }

    void AudioSet()
    {
        if (audioClipCheck && audioModeCheck)
        {
            //CONSTANT
            SetConstant();
        }
        else if (audioClipCheck)
        {
            Debug.Log(gameObject.name + " SOMETHING AUDIO HASN'T BEEN SET");
            Debug.Break();
        }
    }

    #endregion
}
