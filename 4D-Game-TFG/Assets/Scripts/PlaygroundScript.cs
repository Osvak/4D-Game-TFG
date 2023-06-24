using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaygroundScript : MonoBehaviour
{
    private Shape4D shape4D;
    private bool rX = false;
    private bool rY = false;
    private bool rZ = false;
    private const float RotationIncrement = 0.1f;

    private void Awake()
    {
        shape4D = GetComponent<Shape4D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            Reset();

        if (Input.GetKeyDown(KeyCode.X))
            rX = !rX;

        if (Input.GetKeyDown(KeyCode.Y))
            rY = !rY;

        if (Input.GetKeyDown(KeyCode.Z))
            rZ = !rZ;

        if (rX)
            RotateWx();

        if (rY)
            RotateWy();

        if (rZ)
            RotateWz();
    }

    private void RotateWx()
    {
        shape4D.rotationW.x += RotationIncrement;
    }

    private void RotateWy()
    {
        shape4D.rotationW.y += RotationIncrement;
    }

    private void RotateWz()
    {
        shape4D.rotationW.z += RotationIncrement;
    }

    private void Reset()
    {
        rX = false;
        rY = false;
        rZ = false;

        shape4D.rotationW = Vector3.zero;
    }

}
