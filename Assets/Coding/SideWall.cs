using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        string wallName = this.transform.name;
        

        hitInfo.gameObject.SendMessage("RestartGame");
        Debug.Log("Panggil dibawah");
        GameManager.instance.Score(wallName);
    }
}
