using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndScreenScript : MonoBehaviour
{
    public TextMeshProUGUI savedPeopleText;
    public TextMeshProUGUI playerStatus;

    private void Awake()
    {
        savedPeopleText.text = "You Managed to save " + ControllerScript.peopleSaved + " People";
        if (playerMovement.playerIsDead == true)
        {
            playerStatus.text = "You may have died, But...";
        }
        if (playerMovement.playerIsDead == false) 
        {
            playerStatus.text = "Not only did you live, But...";
        }
    }
}
