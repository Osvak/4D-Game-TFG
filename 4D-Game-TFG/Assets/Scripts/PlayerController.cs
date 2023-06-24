using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

// ****************** Player 3D Movement ****************** 

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public float DeathDistance;

    private Vector3 StartPos;

    private void Start()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < DeathDistance)
        {
            transform.position = StartPos;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EndGame();
        }
        MovePlayer();

    }

    void MovePlayer()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            Vector3 cameraForward = Camera.main.transform.forward;
            Vector3 cameraRight = Camera.main.transform.right;

            cameraForward.y = 0f;
            cameraRight.y = 0f;

            cameraForward.Normalize();
            cameraRight.Normalize();

            Vector3 movementDirection = (cameraForward * Input.GetAxis("Vertical") + cameraRight * Input.GetAxis("Horizontal")).normalized;

            transform.Translate(movementDirection * Time.deltaTime * playerSpeed, Space.World);

            if (movementDirection != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(movementDirection);
            }
        }
    }


    public void EndGame()
    {
        Destroy(GameObject.Find("MusicManager"));
        SceneManager.LoadScene(0);
    }

}
