using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Needed to load different scenes

public class MenuCanvasScript : MonoBehaviour
{
    
    
    public GameObject playlistPanel; // Declare playlist panel gameObject
   
    public bool playlistPanelEnabled; // Declare a boolean for our playList panel object that will be set to false at game start

    public static MenuCanvasScript instance; // Creates a static variable for a MenuCanvasScript instance

    public bool playing = false; // Playing boolean set to false
    public AudioSource musicSource; // AudioSource component in Canvas game object
    public AudioClip[] playlistOne; // Array that will hold tracks for playlist one
    public AudioClip[] playlistTwo; // Array that will hold tracks for playlist two
    public AudioClip[] playlistThree; // Array that will hold tracks for playlist three

    private bool muted = false; // Muted boolean set to false

    private void Awake() // Called when a scene is loaded
    {
               
        playlistPanelEnabled = false; // Set our boolean to false    
        playlistPanel.SetActive(true); // Disable our playlist panel gameObject
        
        
    }

    private void Update()
    {
        
    }

  

    

    public void PressPlaylistButtonOne() // Function to start PlaylistOne coroutine
    {
        StartCoroutine(PlaylistOne());
    }
    public void PressPlaylistButtonTwo() // Function to start PlaylistTwo coroutine
    {
        StartCoroutine(PlaylistTwo());
    }
    public void PressPlaylistButtonThree() // Function to start PlaylistThree coroutine
    {
        StartCoroutine(PlaylistThree());
    }

    IEnumerator PlaylistOne() // Will loop through tracks in playlistOne AudioClip array
    {
        if (!playing) // If the playing boolean is false
        {
            playing = true; // Set playing boolean to true
        }

        if (muted) // if the muted boolean is equal to true
        {
            muted = false; // Set the muted boolean to false
            musicSource.volume = 1; // Set the AudioSource volume to full volume
        }

        yield return null; // Wait for next frame

        while (playing) // While the playing boolean is equal to true, loop through the following
        {
            for (int i = 0; i < playlistOne.Length; i++) // Run this loop while the variable "i" (set to 0 at start of loop) is less than the amount of tracks in the playlistOne array
            {
                musicSource.clip = playlistOne[i]; // Set musicSource clip to playlistOne track number "i"

                musicSource.Play(); // Play the AudioSource

                while (musicSource.isPlaying) // While AudioSource is playing a track
                {
                    yield return null; // Wait for next frame
                }
            }
        }
    }

    IEnumerator PlaylistTwo() // Will loop through tracks in playlistTwo AudioClip array
    {
        if (!playing) // If the playing boolean is false
        {
            playing = true; // Set playing boolean to true
        }

        if (muted) // if the muted boolean is equal to true
        {
            muted = false; // Set the muted boolean to false
            musicSource.volume = 1; // Set the AudioSource volume to full volume
        }

        yield return null; // Wait for next frame

        while (playing) // While the playing boolean is equal to true, loop through the following
        {
            for (int i = 0; i < playlistTwo.Length; i++)// Run this loop while the variable "i" (set to 0 at start of loop) is less than the amount of tracks in the playlistTwo array
            {
                musicSource.clip = playlistTwo[i]; // Set musicSource clip to playlistTwo track number "i"

                musicSource.Play(); // Play the AudioSource

                while (musicSource.isPlaying) // While AudioSource is playing a track
                {
                    yield return null; // Wait for next frame
                }
            }
        }
    }

    IEnumerator PlaylistThree() // Will loop through tracks in playlistThree AudioClip array
    {
        if (!playing) // If the playing boolean is false
        {
            playing = true; // Set playing boolean to true
        }

        if (muted) // if the muted boolean is equal to true
        {
            muted = false; // Set the muted boolean to false
            musicSource.volume = 1; // Set the AudioSource volume to full volume
        }

        yield return null; // Wait for next frame

        while (playing) // While the playing boolean is equal to true, loop through the following
        {
            for (int i = 0; i < playlistThree.Length; i++) // Run this loop while the variable "i" (set to 0 at start of loop) is less than the amount of tracks in the playlistThree array
            {
                musicSource.clip = playlistThree[i]; // Set musicSource clip to playlistThree track number "i"

                musicSource.Play(); // Play the AudioSource

                while (musicSource.isPlaying) // While AudioSource is playing a track
                {
                    yield return null; // Wait for next frame
                }
            }
        }
    }

    public void PressMuteButton() // If the mute button is pressed
    {
        if (muted) // If the muted boolean is equal to true
        {
            musicSource.volume = 1; // Set the AudioSource volume to full volume
        }
        else // If the muted boolean is equal to false
        {
            musicSource.volume = 0;  // Set the AudioSource volume to no volume
        }
        muted = !muted; // Switch the value of the muted boolean
    }
}
