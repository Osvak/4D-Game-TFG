using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenu : MonoBehaviour
{
    [SerializeField] public GameObject mainMenu;

    public bool isControlsEnable = false;
    [SerializeField] public GameObject controlsMenu;

    public bool isVideoPlaying = false;
    [SerializeField] public VideoPlayer videoPlayer;
    [SerializeField] public GameObject rawImage;

    [SerializeField] public GameObject audioPlayer; 

    public GameObject title;

    private void Start()
    {
        videoPlayer.Stop();
        videoPlayer.Prepare();
    }

    private void Update()
    {

        StopVideo();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ControlsDisplay()
    {
        if (isControlsEnable == false)
        {
            isControlsEnable = true;
            controlsMenu.SetActive(true);
            mainMenu.SetActive(false);
        }
        else
        {
            isControlsEnable = false;
            controlsMenu.SetActive(false);
            mainMenu.SetActive(true);
        }
    }

    public void PlayVideo()
    {
        if (isVideoPlaying == false)
        {
            isVideoPlaying = true;
            rawImage.SetActive(true);
            mainMenu.SetActive(false);
            title.SetActive(false);
            audioPlayer.GetComponent<AudioSource>().Pause();

            videoPlayer.Play();

        }
    }

    public void StopVideo()
    {
        if (isVideoPlaying == true && (videoPlayer.frame >= (long)videoPlayer.frameCount - 1))
        {

            Debug.Log("Video ended");

            isVideoPlaying = false;
            rawImage.SetActive(false);
            mainMenu.SetActive(true);
            title.SetActive(true);

            audioPlayer.GetComponent<AudioSource>().UnPause();

            videoPlayer.Stop();
        }
    }
}
