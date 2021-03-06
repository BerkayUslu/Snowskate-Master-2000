using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustTrailParticle;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        dustTrailParticle.Play();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        dustTrailParticle.Stop();
    }
}
