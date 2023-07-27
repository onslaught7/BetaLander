using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This object is Friendly");
                break;
            case "Finish":
                Debug.Log("Congrats! You Finished");
                break;
            case "Fuel":
                Debug.Log("You Picked Up fuel");
                break;
            default:
                Debug.Log("You Blew Up");
                break;
        }
    }
}

