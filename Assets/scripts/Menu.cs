using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {


	void Start () {
        gameObject.SetActive(false);
    }
	

    public void open_menu()
    {
        gameObject.SetActive(true);
    }
    
    public void restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void game_exit()
    {
        Application.Quit();
    }
}
