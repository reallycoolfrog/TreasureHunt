using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBehavior : MonoBehaviour
{
    SpriteRenderer myRenderer;
    public Sprite endSprite;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){ //Collide w/ player
            myRenderer.sprite = endSprite;
        } 
    }
}
