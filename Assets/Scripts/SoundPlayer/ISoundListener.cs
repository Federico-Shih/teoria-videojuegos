using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISoundListener {
    AudioClip clip { get; } // Linkeamos con el asset de audio
    AudioSource source { get; } // Fuente de sonido
    void Init();
    void Play();
    void Stop();
    void PlayOneShot();
        
}
