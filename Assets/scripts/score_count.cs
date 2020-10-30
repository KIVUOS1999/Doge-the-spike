using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_count : MonoBehaviour
{
    public Text s;
    public int i = 0;
    public GameObject gb;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gb != null)
        {
            s.text = i.ToString();
            i++;
        }  
    }
}
