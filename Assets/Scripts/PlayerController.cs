using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 10f;
    float surfaceSpeed;

    SurfaceEffector2D surfaceEffector;
    Rigidbody2D rigidBody;
    bool isControllerLockOn = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
        surfaceSpeed = surfaceEffector.speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isControllerLockOn)
        {
            //Boosts the player speed by changing the surface effector speed
            SpeedBooster();
            //rotates the character
            RotatePlayer();
        }
    }

    private void SpeedBooster()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            surfaceEffector.speed = 35;
        }
        else
        {
            surfaceEffector.speed = surfaceSpeed;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.AddTorque(-torqueAmount);
        }
    }
    public void LockTheController()
    {
        isControllerLockOn = true;
    }
}


