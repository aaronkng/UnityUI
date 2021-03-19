using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGoOffscreen : MonoBehaviour
{
    public List<GameObject> MoveObjects;
    
    public void moveOffscreen()
    {
        foreach(GameObject obj in MoveObjects)
        {
            obj.GetComponent<Animator>().SetBool("onScreen", false);
        }
    }
}
