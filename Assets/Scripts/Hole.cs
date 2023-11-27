using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Balls b = other.gameObject.GetComponent<Balls>();

        if (b != null)
        {
            GameManager.instance.PlayerScore += b.Point;
            GameManager.instance.UpdatedScoreText(); 
            Destroy(b.gameObject);
        }
    }
}
