using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_controller : MonoBehaviour
{

    public GameObject about_box;
    public void start_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void about()
    {
        about_box.SetActive(true);
    }

    public void about_close()
    {
        about_box.SetActive(false);
    }

    public void QUIT_GAME()
    {
        Application.Quit();
    }

}
