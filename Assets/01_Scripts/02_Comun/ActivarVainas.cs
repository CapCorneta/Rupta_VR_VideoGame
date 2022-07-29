using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarVainas : MonoBehaviour
{
    public GameObject musica;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tren"))
        {
            musica.SetActive(true);
        }
    }
}
