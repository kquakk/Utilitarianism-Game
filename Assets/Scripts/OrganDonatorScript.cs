using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class OrganDonatorScript : MonoBehaviour
{

    public static bool hasOrgan;
    public static bool DonatorIsAlive;
    [SerializeField] bool canBeSaved;

    private void Start()
    {
        DonatorIsAlive = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.tag.Equals("Donator"))
        {
            hasOrgan = true;
            DonatorIsAlive = false;
            Debug.Log("touchingdonator");
        }

        if (gameObject.tag.Equals("Receiver") && hasOrgan && canBeSaved)
        {
            hasOrgan = false;
            canBeSaved = false;

            if (SavePerson() == true)
            {
                ControllerScript.SavePeople(1);
            } else
            {
                Debug.Log("dead");
            }
        }
    }

    bool SavePerson()
    {
        if (Random.Range(1, 100) >= 50)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
