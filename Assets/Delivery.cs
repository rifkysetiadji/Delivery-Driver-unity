using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool paketDiPickup;
    [SerializeField] Color32 punyaPaket = new Color32(69, 204, 18, 255);
    [SerializeField] Color32 gaPunyaPaket = new Color32(255, 255, 255, 255);

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Paket" && !paketDiPickup)
        {
            paketDiPickup = true;
            spriteRenderer.color = punyaPaket;
            Destroy(collision.gameObject);
            Debug.Log(collision.tag);
        }
        if(collision.tag == "Tujuan" && paketDiPickup)
        {
            paketDiPickup = false;
            spriteRenderer.color = gaPunyaPaket;

            Debug.Log(collision.tag);
        }
    }
}
