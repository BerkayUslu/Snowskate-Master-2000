using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float crashDelayTime = 1f;
    [SerializeField] ParticleSystem crashEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "Ground")
        {
            
                crashEffect.Play();
            
            
            Invoke("loadScene",crashDelayTime);
        }
    }

    private void loadScene()
    {
        SceneManager.LoadScene(0);
    }
}
