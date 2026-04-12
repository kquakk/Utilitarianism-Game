using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomizerScript : MonoBehaviour
{
    public GameObject colorSquare1;
    public GameObject colorSquare2;
    public GameObject colorSquare3;
    public GameObject colorSquare4;

    [SerializeField] SpriteRenderer rend1;
    [SerializeField] SpriteRenderer rend2;
    [SerializeField] SpriteRenderer rend3;
    [SerializeField] SpriteRenderer rend4;

    public Color color1 = Color.magenta;
    public Color color2 = Color.blue;
    public Color color3 = Color.green;
    public Color color4 = Color.yellow;
    public float switchInterval = 0.5f;
    private bool isSwitching = false;

    public void StartColorSwitching()
    {
        if(!isSwitching && rend1 != null)
        {
            StartCoroutine(SwitchColorsForDuration(5f));
        }
    }

    private IEnumerator SwitchColorsForDuration(float duration)
    {
        isSwitching = true;
        float elapsedTime = 0f;
        bool toggle = false;

        while (elapsedTime < duration)
        {
            rend1.color = toggle ? color1 : color2;
            rend2.color = toggle ? color2 : color1;
            rend3.color = toggle ? color4 : color3;
            rend4.color = toggle ? color3 : color2;
            toggle = !toggle;
            elapsedTime += switchInterval;
            yield return new WaitForSeconds(switchInterval);
        }

    }
}
