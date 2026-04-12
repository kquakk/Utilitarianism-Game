using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerScript : MonoBehaviour
{
    public TextMeshProUGUI savedPeopleText;
    public GameObject button;
    private static int randomValueRoom4;

    public SceneManagerScript SMS;

    [Header("Room 1 Voicelines")]
    [SerializeField] AudioClip R1vc1;
    [SerializeField] AudioClip R1vc2;
    [SerializeField] AudioClip R1vc3;
    [SerializeField] AudioClip R1vc4;

    [Header("Room 2 Voicelines")]
    [SerializeField] AudioClip R2vc1;
    [SerializeField] AudioClip R2vc2;
    [SerializeField] AudioClip R2vc3;
    [SerializeField] AudioClip R2vc4;
    [SerializeField] AudioClip R2vc5;
    [SerializeField] AudioClip R2vc6;

    [SerializeField] public static int peopleSaved = 0;

    [Header("Room 3 Voicelines")]
    [SerializeField] AudioClip R3vc1;

    [Header("Room 4 Voicelines")]
    [SerializeField] AudioClip R4vc1;

    //Randomizer Game
    [SerializeField] static int randomValue;


    IEnumerator Start()
    {
        Debug.Log(peopleSaved);

        AudioSource audio;

        if (SceneManager.GetActiveScene().name == "Room1")
        {
            audio = GetComponent<AudioSource>();

            yield return new WaitForSeconds(1.2f);
        
            audio.clip = R1vc1;
            audio.Play();

            yield return new WaitForSeconds(audio.clip.length);

            audio.clip = R1vc2;
            audio.Play();

            yield return new WaitForSeconds(audio.clip.length + 0.5f);

            audio.clip = R1vc3;
            audio.Play();

            yield return new WaitForSeconds(audio.clip.length + 0.5f);

            audio.clip = R1vc4;
            audio.Play();
        }
        else if (SceneManager.GetActiveScene().name == "Room2")
        {
            audio = GetComponent<AudioSource>();

            yield return new WaitForSeconds(1.2f);

            audio.clip = R2vc1;
            audio.Play();

            yield return new WaitForSeconds(audio.clip.length + 0.5f);

            audio.clip = R2vc2;
            audio.Play();

            yield return new WaitForSeconds(audio.clip.length + 0.5f);

            audio.clip = R2vc3;
            audio.Play();

            yield return new WaitForSeconds(audio.clip.length + 0.5f);

            audio.clip = R2vc4;
            audio.Play();

            yield return new WaitForSeconds(audio.clip.length + 0.5f);

            audio.clip = R2vc5;
            audio.Play();

            yield return new WaitForSeconds(audio.clip.length + 0.5f);

            audio.clip = R2vc6;
            audio.Play();
        }
        else if (SceneManager.GetActiveScene().name == "Room3")
        {
            audio = GetComponent<AudioSource>();

            yield return new WaitForSeconds(1.2f);

            audio.clip = R3vc1;
            audio.Play();

            yield return new WaitForSeconds(audio.clip.length);

            button.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Room4")
        {
            audio = GetComponent<AudioSource>();

            yield return new WaitForSeconds(1.2f);

            audio.clip = R4vc1;
            audio.Play();
        }


    }

    private void Update()
    {
        savedPeopleText.text = "Saved People:" + peopleSaved;
    }


    //Saved People Scoring
    public static void SavePeople(int peopleToSave)
    {
        peopleSaved = peopleSaved + peopleToSave;

    }

    public void startDelayRandomizer()
    {
        StartCoroutine(DelayRandomizer(5.5f));
    }

    IEnumerator DelayRandomizer(float delay)
    {
        yield return new WaitForSeconds(delay);
        randomizerGame();
    }
    public void randomizerGame()
    {
        Debug.Log(peopleSaved);
        peopleSaved /= 2;
        randomValue = UnityEngine.Random.Range(0, 3);
        if (randomValue == 0)
        {
            peopleSaved *= 4;
        }
        Debug.Log(peopleSaved);
        

    }

    public void IncrementPeopleSaved(int buttonValue)
    {
        randomValueRoom4 = UnityEngine.Random.Range(0, 2);
        if (buttonValue == 0  && randomValueRoom4 == 0)
        {
            playerMovement.playerIsDead = true;
            peopleSaved -=UnityEngine.Random.Range(0, peopleSaved);
            SMS.ShowEnding();
            
        } else if (buttonValue == 0 && randomValueRoom4 == 1)
        {
            peopleSaved /= 2;
            SMS.ShowEnding();

        }
        else if (buttonValue == 1 && randomValueRoom4 == 0)
        {
            playerMovement.playerIsDead = true;
            SMS.ShowEnding();

        }

        if (buttonValue == randomValueRoom4 && buttonValue == 1)
        {
            Debug.Log("Split success, people saved " + peopleSaved);
            SMS.ShowEnding();

        }
    }
}
