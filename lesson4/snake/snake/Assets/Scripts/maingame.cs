using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maingame : MonoBehaviour
{
    public GameObject SnakeHead;
    GameObject SnakeObj;
    int gameMode = 0;
    int score = 0;
    public GameObject ApplePref;
    int time = 0;
    int time2 = 0;
    int maxTime = 150;
    List<GameObject> Apples = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        //createSnake();
    }

    // Update is called once per frame
    float xx = 0, yy = 0;
    void Update()
    {
        time++;
        time2++;
        if (time >= maxTime)
        {
            GameObject apple = Instantiate(ApplePref) as GameObject;
            Apples.Add(apple);
            time = 0;
            Destroy(Apples[0]);
        }

        if(time >= maxTime * 5)
        {
            GameObject apple = Apples[0];
            Destroy(apple);
            Apples.Remove(apple);
            time2 = 0;
        }


        if (SnakeObj != null)
        {
            xx = 0;
            yy = 0;
            if (Input.GetAxis("Horizontal")  > 0)
            {
                xx = 1;
            } else if (Input.GetAxis("Horizontal") < 0)
            {
                xx = -1;
            }

            if (Input.GetAxis("Vertical")  > 0)
            {
                yy = 1;
            }
            if (Input.GetAxis("Vertical") < 0)
            {
                yy = -1;
            }
            
            if (xx !=0 || yy != 0)
            {
                Snakelife s = SnakeObj.GetComponent<Snakelife>();
                if (xx!=0) { s.direction = new Vector2(xx, 0); }
                if (yy!=0) { s.direction = new Vector2(0, yy); }
            }
        }
    }


    void createSnake()
    {
        SnakeObj = Instantiate(SnakeHead) as GameObject;
        SnakeObj.name = "Snake";
        gameMode = 1;
    }

    void OnGUI()
    {
        int posX = Screen.width / 2;
        int posY = Screen.height / 2;
        switch (gameMode)
        {
            case 0:
               Boolean stateBtn1 = GUI.Button(new Rect(new Vector2(posX - 100, posY), new Vector2(200, 30)), "game start ");


               Boolean stateBtn2 = GUI.Button(new Rect(new Vector2(posX - 100, posY+50), new Vector2(200, 30)), "exit ");
                if (stateBtn1)
                {
                    createSnake();
                }
                if (stateBtn2)
                {
                    Application.Quit();
                }

                break;
            case 1: 
                Snakelife snakeL = SnakeHead.GetComponent<Snakelife>();
                if(snakeL != null)
                {
                    score = snakeL.snakeScore;
                    GUI.Label(new Rect(
                        new Vector2(posX-20, 0), new Vector2(200, 30)
                        ), "Score:" + score);
                }
                break;
        }

    }    


}




   




    
