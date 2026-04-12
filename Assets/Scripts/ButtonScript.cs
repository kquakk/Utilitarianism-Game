using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] string personToSave;

    bool canChoose;
    bool canSaveSomeone;

    public TextMeshProUGUI peopleSavedText;

    private void Start()
    {
        canSaveSomeone = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (TrolleyGameScript.TGCountdown > 0)
        {
            canChoose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (TrolleyGameScript.TGCountdown > 0)
        {
            canChoose = false;
        }
    }

    private void Update()
    {
        if (canChoose && Input.GetKey(KeyCode.Space) && canSaveSomeone)
        {
            if(personToSave == "Parents")
            {
                TrolleyGameScript.TGCountdown = 0;
                TrolleyGameScript.savedParents = true;

                ControllerScript.SavePeople(2);
                canSaveSomeone = false;
            }
            else if (personToSave == "Sibling")
            {
                TrolleyGameScript.TGCountdown = 0;
                TrolleyGameScript.savedSibling = true;

                ControllerScript.SavePeople(1);
                canSaveSomeone = false;

            }

            Debug.Log(personToSave);
        }
    }
}
