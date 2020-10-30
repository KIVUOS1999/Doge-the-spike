using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class movement : MonoBehaviour
{
    private Vector2 pos;
    public float y_increment, speed, max_height, min_height, Health;
    public GameObject effect;
    public GameObject sound;
    public Animator camshake;
    private float verticle = 0f;
    public Slider slider;
 

    void Update()
    {
        

        slider.value = Health;

        if (Health <= 0)
        {
            //Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, pos, speed * Time.deltaTime);

        if (verticle>0)
        { 
            if(transform.position.y == 0)
                pos = new Vector2(transform.position.x, y_increment);
            else if(transform.position.y == -y_increment)
                pos = new Vector2(transform.position.x, 0);

            Instantiate(effect, transform.position, Quaternion.identity);
            GameObject d = Instantiate(sound, transform.position, Quaternion.identity);
            Destroy(d, 2);
            camshake.SetTrigger("shake");
        }

        if (verticle<0)
        {
            if (transform.position.y == 0)
                pos = new Vector2(transform.position.x, -y_increment);
            else if (transform.position.y == y_increment)
                pos = new Vector2(transform.position.x, 0);

            Instantiate(effect, transform.position, Quaternion.identity);
            GameObject d = Instantiate(sound, transform.position, Quaternion.identity);
            Destroy(d, 2);
            camshake.SetTrigger("shake");
        }

        verticle = 0f;
        
    }

    public void UP_BUTTON()
    {
        verticle = 1;
    }

    public void DOWN_BUTTON()
    {
        verticle = -1;
    }

    
}
