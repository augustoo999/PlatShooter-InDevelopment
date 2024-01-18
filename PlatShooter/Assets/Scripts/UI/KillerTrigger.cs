using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillerTrigger : MonoBehaviour
{
    [SerializeField]
    private string CenaAtual;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out var player))
        {
            SceneManager.LoadScene(CenaAtual);
        }
    }
}
