using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        //Here, we used 'other', that is comming from the method parameters, 
        //because we want to check that if another object (with Player tag) 
        //has hit into the current one, that 
        //is using the current ObjectHit script!
        if (other.gameObject.tag == "Player") 
        {
        GetComponent<MeshRenderer>().material.color = Color.red;
        //And here we will be using without other, because we will be changing 
        //the tag of the current object!
        gameObject.tag = "Hit";
        }
    }
}
