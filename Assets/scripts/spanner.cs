using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spanner : MonoBehaviour
{
    public GameObject[] go;
    public float updatespan;
    private float spantime;
    private int score;
    public GameObject enemy;

    // Update is called once per frame
    void Update()
    {

        score = FindObjectOfType<score_count>().i;

        if (spantime<=0)
        {
            int rand = Random.Range(0, go.Length);

            Instantiate(go[rand], transform.position, Quaternion.identity);
            spantime = updatespan;

            if(score % 100 == 0)
            {
                enemy.GetComponent<enemy>().i *= 1.5f;
            }
        }
        else
        {
            spantime -= Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
