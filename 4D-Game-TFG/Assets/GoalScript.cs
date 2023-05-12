using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class GoalScript : MonoBehaviour
{
    //void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("Collision");
    //    if (other.gameObject.tag == "Goal")
    //    {
    //        Debug.Log("goal");
    //        SceneManager.LoadScene(0);
    //    }
    //}

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

}
