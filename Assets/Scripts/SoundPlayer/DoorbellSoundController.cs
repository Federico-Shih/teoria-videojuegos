using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]     // Obligatorio tener un AudioSource
public class DoorbellSoundController : MonoBehaviour, ISoundListener
{
    #region ISoundProperties
    public AudioClip clip => _clip;

    public AudioSource source => _source;

    [SerializeField] private AudioClip _clip;
    [SerializeField] private AudioSource _source;

    #endregion

    #region Unity_Events
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) Play();
        if (Input.GetKeyDown(KeyCode.Alpha2)) Play();
        if (Input.GetKeyDown(KeyCode.Alpha3)) PlayOneShot();
    }
    #endregion

    #region ISoundActions
    public void Init()
    {
        _source = GetComponent<AudioSource>();// dentro donde esta metido el script, agarra automaticamente el source
        // si no lo tiene, deveulve Null
        _source.clip = _clip;
    }

    public void Play() => _source.Play();

    // Emite el efecto 1 vez 
    public void PlayOneShot() => _source.PlayOneShot(_clip);
    

    public void Stop() => _source.Stop();
    
    #endregion
}

