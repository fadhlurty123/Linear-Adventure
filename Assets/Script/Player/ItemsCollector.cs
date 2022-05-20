using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemsCollector : MonoBehaviour
{
    private int apple = 0;

    [SerializeField] private Text AppleText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
           // Destroy(collision.gameObject);
            apple++;
            AppleText.text = "Apple : " + apple;
            
        }
    }
}
