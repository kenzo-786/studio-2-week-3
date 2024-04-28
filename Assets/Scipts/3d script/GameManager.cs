using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject winScreen;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Treasure")
        {
            Time.timeScale = 0f;
            winScreen.SetActive(false);
        }
    }
}
