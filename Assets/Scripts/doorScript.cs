using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorScript : MonoBehaviour
{

    public SceneManagerScript SMS;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (SceneManager.GetActiveScene().name == "Room1")
        {
            SMS.EnterRoom2();
        } else if (SceneManager.GetActiveScene().name == "Room2")
        {
            SMS.EnterRoom3();
        } else if (SceneManager.GetActiveScene().name == "Room3")
        {
            SMS.EnterRoom4();
        }
    }
}
