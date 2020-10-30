using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    public int damage = 1;
    public float i;
    public float speed = 10f;
    private float destroy = 10;
    public GameObject effect;
    public GameObject collision_sound;

    private void Start()
    {
        i = speed;
    }

    private void Update()
    {
        transform.Translate(Vector2.left * i * Time.deltaTime);
        if (destroy <= 0)
        {
            Destroy(gameObject);
        }
        else
            destroy -= Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent < movement > ().Health -= damage;
            Destroy(gameObject);
            Instantiate(effect, transform.position, Quaternion.identity);
            Instantiate(collision_sound, transform.position, Quaternion.identity);
        }
        
    }
}
