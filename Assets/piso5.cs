using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piso5 : MonoBehaviour
{
    private AudioSource musi4;
    // Start is called before the first frame update
    void Start()
    {
        musi4 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            musi4.Play();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            musi4.Stop();
        }
    }
}
