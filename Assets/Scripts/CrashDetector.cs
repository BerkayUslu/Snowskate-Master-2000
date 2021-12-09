using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float crashDelayTime = 1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip[] crashAudio;
    PlayerController playerController;
    bool isCrashHappened = false;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "Ground")
        {
            if (!isCrashHappened)
            {
                isCrashHappened = true;
                playerController.LockTheController();
                GetComponent<AudioSource>().clip = crashAudio[0];
                GetComponent<AudioSource>().Play();
                crashEffect.Play();
                Invoke("loadScene", crashDelayTime);
            }
        }
    }

    private void loadScene()
    {
        SceneManager.LoadScene(0);
    }
}
