
//using System.Diagnostics;
using UnityEngine;



public class Coin : MonoBehaviour
{
    /*private void OnTriggerEnter2d(Collider2D collision)
    {
        Debug.Log("Coin collected!");

        if (collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.coins += 1;
            Destroy(gameObject);
        }
    }*/

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Coin collected!");

        if (collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.coins += 1;
            Destroy(gameObject);
        }
    }
}
