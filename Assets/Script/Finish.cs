using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSoundEffect;
    private bool levelComplited = false;
    void Start()
    {
        finishSoundEffect = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player" && !levelComplited)
        {
            finishSoundEffect.Play();
            levelComplited = true;
            Invoke("CompleateLevel", 2f);
        }
    }

    private void CompleateLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
