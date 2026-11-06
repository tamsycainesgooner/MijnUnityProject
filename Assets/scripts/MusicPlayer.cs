
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    string currentSong = "none";
    float volume = 1.0f;

    void Start()
    {
        Debug.Log("Music Player is ready!");
    }

    void Update()
    {
        // P = Play
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlaySong("Chaconne by Enhypen");
            Debug.Log(GetCurrentSong());
        }

        // S = Stop
        if (Input.GetKeyDown(KeyCode.S))
        {
            StopSong();
        }

        // V = Volume
        if (Input.GetKeyDown(KeyCode.V))
        {
            SetVolume(0.5f);
        }

        // I = Check if playing
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("Is playing: " + IsPlaying());
        }
    }

    void PlaySong(string songName)
    {
        Debug.Log("Playing song: " + songName);
        currentSong = songName;
    }

    void StopSong()
    {
        Debug.Log("Stopping song: " + currentSong);
        currentSong = "none";
    }

    string GetCurrentSong()
    {
        return currentSong;
    }

    void SetVolume(float newVolume)
    {
        volume = newVolume;
        Debug.Log("Setting volume to: " + volume);
    }

    bool IsPlaying()
    {
        return currentSong != "none";
    }
}
