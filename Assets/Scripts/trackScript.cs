using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class trackScript : MonoBehaviour
{
    [SerializeField] GameObject saveWhoText;

    private void Start()
    {
        saveWhoText.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        saveWhoText.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        saveWhoText.SetActive(false);
    }
}
