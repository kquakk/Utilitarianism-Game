using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class TrolleyGameScript : MonoBehaviour
{
    [SerializeField] AudioClip vc5;
    [SerializeField] AudioClip vc6;
    [SerializeField] AudioClip vc7;

    AudioSource audio;
    private IEnumerator Coroutine;

    public static int TGCountdown;
    public static bool savedParents;
    public static bool savedSibling;

    public GameObject exitDoor;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Coroutine = StartTrolleyProblem();

        StartCoroutine(Coroutine);
    }


    IEnumerator StartTrolleyProblem()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = vc5;
        audio.Play();

        yield return new WaitForSeconds(audio.clip.length + 0.3f);

        audio.clip = vc6;
        audio.Play();

        TGCountdown = 20;

        yield return new WaitForSeconds(20);

        audio.clip = vc7;
        audio.Play();
        exitDoor.SetActive(true);
    }
}
