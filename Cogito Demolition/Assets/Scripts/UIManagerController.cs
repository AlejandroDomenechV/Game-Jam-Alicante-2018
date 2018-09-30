using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManagerController : MonoBehaviour {

    public static int selecter = 0;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "game over" || scene.name == "win")
        {
            this.gameOverMenu();
        }
        else if (scene.name == "main menu")
        {
            this.mainMenu();
        }

    }

    public void mainMenu()
    {
        GameObject boton;

        //menu inicio
        if (Input.GetKey(KeyCode.UpArrow))
        {

            if (selecter == 0)
            {
                selecter = 3;

                boton = GameObject.FindGameObjectWithTag("quit_button");

                //Highlight
                ColorBlock colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, .3f);
                boton.GetComponent<Button>().colors = colorAux;

                //others
                boton = GameObject.FindGameObjectWithTag("credits_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;

                boton = GameObject.FindGameObjectWithTag("play_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;
            }
            else if (selecter == 3)
            {
                selecter = 2;

                boton = GameObject.FindGameObjectWithTag("credits_button");

                //Highlight
                ColorBlock colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, .3f);
                boton.GetComponent<Button>().colors = colorAux;

                //others
                boton = GameObject.FindGameObjectWithTag("quit_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;

                boton = GameObject.FindGameObjectWithTag("play_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;
            }
            else if (selecter == 2)
            {
                selecter = 1;

                boton = GameObject.FindGameObjectWithTag("play_button");

                //Highlight
                ColorBlock colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, .3f);
                boton.GetComponent<Button>().colors = colorAux;

                //others
                boton = GameObject.FindGameObjectWithTag("credits_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;

                boton = GameObject.FindGameObjectWithTag("quit_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;

            }


        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {


            if (selecter == 0)
            {
                selecter = 1;
                boton = GameObject.FindGameObjectWithTag("play_button");

                //Highlight
                ColorBlock colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, .3f);
                boton.GetComponent<Button>().colors = colorAux;

                //others
                boton = GameObject.FindGameObjectWithTag("credits_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;

                boton = GameObject.FindGameObjectWithTag("quit_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;

                // boton.SetActive(true);
            }
            else if (selecter == 1)
            {
                selecter = 2;

                //new
                boton = GameObject.FindGameObjectWithTag("credits_button");

                ColorBlock colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, .3f);
                boton.GetComponent<Button>().colors = colorAux;


                //others
                boton = GameObject.FindGameObjectWithTag("play_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;

                boton = GameObject.FindGameObjectWithTag("quit_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;
            }
            else if (selecter == 2)
            {
                selecter = 3;

                //new
                boton = GameObject.FindGameObjectWithTag("quit_button");

                ColorBlock colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, .3f);
                boton.GetComponent<Button>().colors = colorAux;


                //last
                boton = GameObject.FindGameObjectWithTag("credits_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;

                boton = GameObject.FindGameObjectWithTag("play_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;
            }

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            if (selecter == 1)
            {
                this.startCinematica();
            }
            else if (selecter == 2)
            {
                this.goToCredits();
            }
            else if (selecter == 3)
            {
                this.closeGame();
            }

        }
    }

    public void gameOverMenu()
    {
        GameObject boton;

        //menu inicio
        if (Input.GetKey(KeyCode.UpArrow))
        {

            if (selecter == 0)
            {
                selecter = 2;

                boton = GameObject.FindGameObjectWithTag("menu_button");

                //new
                ColorBlock colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, .3f);
                boton.GetComponent<Button>().colors = colorAux;

                //others
                boton = GameObject.FindGameObjectWithTag("replay_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;

            }
            else if (selecter == 2)
            {
                selecter = 1;

                boton = GameObject.FindGameObjectWithTag("replay_button");

                //new
                ColorBlock colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, .3f);
                boton.GetComponent<Button>().colors = colorAux;

                //others
                boton = GameObject.FindGameObjectWithTag("menu_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;

            }


        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {


            if (selecter == 0)
            {
                selecter = 1;
                boton = GameObject.FindGameObjectWithTag("replay_button");

                //Highlight
                ColorBlock colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, .3f);
                boton.GetComponent<Button>().colors = colorAux;

                //others
                boton = GameObject.FindGameObjectWithTag("menu_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;


            }
            else if (selecter == 1)
            {
                selecter = 2;

                //new
                boton = GameObject.FindGameObjectWithTag("menu_button");

                ColorBlock colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, .3f);
                boton.GetComponent<Button>().colors = colorAux;


                //others
                boton = GameObject.FindGameObjectWithTag("replay_button");

                colorAux = boton.GetComponent<Button>().colors;
                colorAux.normalColor = new Color(255f, 0f, 0f, 1f);
                boton.GetComponent<Button>().colors = colorAux;

            }

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            if (selecter == 1)
            {
                this.startGame();
            }
            else if (selecter == 2)
            {
                this.goToMenu();
            }

        }
    }



    public void startCinematica() {
        SceneManager.LoadScene("Cinematica");
    }
    public void startGame()
    {
        GameManagerController.score = 0;
        GameManagerController.time = 0;
        GameManagerController.platformCount = 1;
        SceneManager.LoadScene("game");
    }
    public void closeGame()
    {
        Application.Quit();
    }
    public void goToMenu()
    {
        SceneManager.LoadScene("main menu");
    }
    public void goToCredits()
    {
        SceneManager.LoadScene("credits");
    }
}

   