using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DropdownScript : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject cylinder;
    public GameObject Cell5;
    public GameObject Cell16;

    public void ChangeShapeActiveState(int index)
    {
        switch (index)
        {
            case 0:
                cube.SetActive(true);
                sphere.SetActive(false);
                cylinder.SetActive(false);
                Cell5.SetActive(false);
                Cell16.SetActive(false);
                break;
            case 1:
                cube.SetActive(false);
                sphere.SetActive(true);
                cylinder.SetActive(false);
                Cell5.SetActive(false);
                Cell16.SetActive(false);
                break;
            case 2:
                cube.SetActive(false);
                sphere.SetActive(false);
                cylinder.SetActive(true);
                Cell5.SetActive(false);
                Cell16.SetActive(false);
                break;
            case 3:
                cube.SetActive(false);
                sphere.SetActive(false);
                cylinder.SetActive(false);
                Cell5.SetActive(true);
                Cell16.SetActive(false);
                break;
            case 4:
                cube.SetActive(false);
                sphere.SetActive(false);
                cylinder.SetActive(false);
                Cell5.SetActive(false);
                Cell16.SetActive(true);
                break;
        }
    }
}
