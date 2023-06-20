using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera camera;
    public GameObject player;
    private Vector3[] camPoints = new Vector3[4];
    private int currentPoint;

    public float transitionDuration = 1f; // Duration of the transition in seconds
    private bool isTransitioning = false; // Flag to track if a transition is already in progress

    private void Awake()
    {
        camPoints[0] = new Vector3(27, 37, -27);
        camPoints[1] = new Vector3(27, 37, 27);
        camPoints[2] = new Vector3(-25, 37, 27);
        camPoints[3] = new Vector3(-27, 37, -27);

        currentPoint = 0;
    }

    private void Update()
    {
        ChangeCamera();

        FollowPlayer();
    }

    void FollowPlayer()
    {
        // camera.transform.LookAt(new Vector3(player.transform.position.x, player.transform.position.y + 2, player.transform.position.z));
        camera.transform.LookAt(Vector3.zero);
    }

    void ChangeCamera()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isTransitioning)
        {
            currentPoint++; // Move to the next campoint

            // Check if we have reached the end of the array
            if (currentPoint >= camPoints.Length)
            {
                currentPoint = 0; // Wrap around to the first campoint
            }

            StartCoroutine(TransitionToCameraPoint(camPoints[currentPoint]));
        }
        else if (Input.GetKeyDown(KeyCode.Q) && !isTransitioning)
        {
            currentPoint--; // Move to the previous campoint

            // Check if we have reached the beginning of the array
            if (currentPoint < 0)
            {
                currentPoint = camPoints.Length - 1; // Wrap around to the last campoint
            }

            StartCoroutine(TransitionToCameraPoint(camPoints[currentPoint]));
        }
    }

    IEnumerator TransitionToCameraPoint(Vector3 targetPosition)
    {
        isTransitioning = true;

        Vector3 startPosition = camera.transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < transitionDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / transitionDuration);
            camera.transform.position = Vector3.Lerp(startPosition, targetPosition, t);
            yield return null;
        }

        camera.transform.position = targetPosition;
        isTransitioning = false;
    }
}

