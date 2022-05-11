using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoCaja : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource[] allAudioSources;
    AudioSource cajaimpact;
    AudioSource cajarumble;
    
    Rigidbody2D rb;
   
    void Start()
    {
        allAudioSources = GetComponents<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        cajaimpact = allAudioSources [0];
        cajarumble = allAudioSources [1];
    }

    // Update is called once per frame
    void Update()
    {
   
 }
     private void OnCollisionEnter2D(Collision2D collision) {
        
        cajaimpact.Play();
        cajarumble.Play();
     }
     

    
}
