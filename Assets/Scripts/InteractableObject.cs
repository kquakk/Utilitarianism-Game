using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : CollidableObject
{
    public InteractableObject otherButton;
    public int buttonValue;
    private bool interacted = false;

    private void Awake()
    {
        if (name.ToLower().Contains("red"))
        {
            buttonValue = 0;
        }
        if (name.ToLower().Contains("blue"))
        {
            buttonValue = 1;
        }
    }

    public override void OnCollided(GameObject collidedObject)
    {
        if (Input.GetKey(KeyCode.Space) & !interacted)
        {
            OnInteract();
        }
    }

    public void OnInteract()
    {
        if (!interacted)
        {
            interacted = true;
            if (otherButton != null)
            {
                otherButton.DisableInteraction();
            }

            ControllerScript controller = FindObjectOfType<ControllerScript>();
            if (controller != null)
            {
                controller.IncrementPeopleSaved(buttonValue);
            }
        }
    }


    public void DisableInteraction()
    {
        interacted = true;
        gameObject.SetActive(false);
    }
}
