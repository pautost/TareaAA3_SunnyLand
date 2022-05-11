using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    AudioSource[] allAudioSources;
    AudioSource landing; 
    AudioSource crouch;
    AudioSource jump;
    AudioSource cherry;
    AudioSource run;
    

    // keep track of the jumping state ... 
    bool isJumping = false; 
    // make sure to keep track of the movement as well !
    bool isMoving = false;
    Rigidbody2D rb; // note the "2D" prefix 
    
    // Start is called before the first frame update
    void Start()
    {
	rb = GetComponent<Rigidbody2D>();
    allAudioSources = GetComponents<AudioSource>();
    landing = allAudioSources [0];
    crouch = allAudioSources [1];
    jump = allAudioSources [2];
    cherry = allAudioSources [3];
    run = allAudioSources [4];
       
    }

    // FixedUpdate is called whenever the physics engine updates
    void FixedUpdate()
    { 

    float v = rb.velocity.magnitude;
        if(v>1 && !isMoving && !isJumping){
            run.Play();
            isMoving = true;
	}
    else if (v<1 && isMoving && !isJumping){
        run.Stop();
        isMoving = false;
    }
}
    
    
    // trigger your landing sound here !
    public void OnLanding() {
        isJumping = false;
        landing.Play();
        print("the fox has landed");
        
    
	// to keep things cleaner, you might want to
	// play this sound only when the fox actually jumoed ...
    }

    // trigger your crouching sound here
    public void OnCrouching() {
        crouch.Play();
        print("the fox is crouching");
        
    }
 
    // trigger your jumping sound here !
    public void OnJump() {
        isJumping = true;
        jump.Play();
        print("the fox has jumped");
        
    }

    // trigger your cherry collection sound here !
    public void OnCherryCollect() {
        cherry.Play();
        print("the fox has collected a cherry");
        
    }
}
