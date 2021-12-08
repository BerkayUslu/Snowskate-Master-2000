using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float finishDelayTime = 1f;
    [SerializeField] ParticleSystem finishEffect;

 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayEffectAndAudio();
            Invoke("loadScene", finishDelayTime);
        }
    }

    private void PlayEffectAndAudio()
    {
        finishEffect.Play();
        GetComponent<AudioSource>().Play();
    }

    private void loadScene()
    {
        SceneManager.LoadScene(0);
    }
}
