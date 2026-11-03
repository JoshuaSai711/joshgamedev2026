using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    Vector3 MoveCoin;
    //The player calls this function on the coin whenever they bump into it
    //You can change its contents if you want something different to happen on collection
    //For example, what if the coin teleported to a new location instead of being destroyed?
    public void GetBumped()

    {
        //In this game I want to spawn a new coin in a random location when you collect the coins 
        MoveCoin = Vector3.zero;
        MoveCoin.x = Random.Range(-5,5);
        MoveCoin.y = Random.Range(-5,5);
        gameObject.transform.position=MoveCoin;
    }
}
