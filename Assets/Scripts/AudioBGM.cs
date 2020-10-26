using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBGM : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip bgm1;
    public AudioClip bgm2;
    public AudioClip bgm3;
    AudioClip currentTrack;
    AudioClip previousTrack; // the previous track that was played

    void Start()
    {
        StartCoroutine(PlayZombieSound());
    }

    IEnumerator PlayZombieSound()
    {
        if (currentTrack == null)
        {
            previousTrack = bgm1;
        }
        currentTrack = previousTrack;
        audioSource.loop = true;
        ChangeTrack(currentTrack);
        yield return new WaitForSeconds(currentTrack.length);

        previousTrack = bgm2;
        currentTrack = previousTrack;
        ChangeTrack(currentTrack);
        yield return new WaitForSeconds(currentTrack.length);

        previousTrack = bgm3;
        currentTrack = previousTrack;
        ChangeTrack(currentTrack);
        yield return new WaitForSeconds(currentTrack.length);

    }

    /// <summary>
    /// play the previous track that was being played
    /// </summary>
    public void PlayPreviousTrack()
    {
        // if there is no previous track
        if (previousTrack == null)
        {
            previousTrack = bgm1;
        }
        currentTrack = previousTrack; // set the current track to the previous track
        ChangeTrack(currentTrack); // play our previous track
    }

    /// <summary>
    /// This function changes the clip being played at the moment
    /// </summary>
    /// <param name="clip"></param>
    public void ChangeTrack(AudioClip clip)
    {
        if (audioSource.clip != clip) // if the current clip in the audio source is not equal to the clip we are trying to play
        {
            previousTrack = audioSource.clip; // store the previous track
            audioSource.clip = clip; // set the new track
        }
        audioSource.loop = true; // set the track to be looping
        audioSource.Play(); // start playing our music
    }
}
