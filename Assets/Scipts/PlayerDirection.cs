using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerDirection : MonoBehaviour
{
    [SerializeField] GameObject hintText;

    private void Start()
    {
        StartCoroutine(playerDirectionText());
    }

    IEnumerator playerDirectionText()
    {
        yield return new WaitForSeconds(5);
        hintText.SetActive(false);
    }
}
