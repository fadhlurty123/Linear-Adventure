using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectedAfterEffect : MonoBehaviour
{
    
    private Animator anim;
    [SerializeField] private AudioSource collectionSoundEffect;
    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collectionSoundEffect.Play();
            Effect();
            Destroy(gameObject, 0.1f);
        }
    }

    private void Effect()
    {
        anim.SetTrigger("AfterEffect");
    }
}
