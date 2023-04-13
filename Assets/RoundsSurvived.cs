using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundsSurvived : MonoBehaviour
{
    public Text RoundsText;

    private void OnEnable()
    {
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        int round = 0;
        RoundsText.text = round.ToString();

        yield return new WaitForSeconds(1f);

        while (round < PlayerStats.Waves)
        {
            round++;
            RoundsText.text = round.ToString();

            yield return new WaitForSeconds(.05f);
        }
    }

}
