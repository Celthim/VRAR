using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsBehaviour : MonoBehaviour
{
    AudioSource aud;
    public GameObject worldObject;

    // Use this for initialization
    void Start()
    {
        worldObject = GameObject.Find("World");
        aud = gameObject.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        Renderer objRenderer;
        Collider objCollider;
        objRenderer = GetComponent<Renderer>();
        objCollider = GetComponent<Collider>();
        objRenderer.enabled = false;
        objCollider.enabled = false;
        if (aud)
        {
            aud.Play();
        }
        worldObject.SendMessage("AddCoin");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
