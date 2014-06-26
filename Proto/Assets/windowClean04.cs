﻿using UnityEngine;
using System.Collections;

public class windowClean04 : MonoBehaviour
{
    int r = 20;
    int r2 = 50;
    bool tf = false;
    string Level = "Room 01";
    public float x, y;
    public Transform goRoom;
    public Transform exit;
    Sprite img;
    Sprite randomImg;
    float W ;
    float H ;
    float w ;
    float h ;
    Vector2 imin;
    Vector2 imax ;
    float wS ;
    float hS ;

    bool inOrOut(Sprite img)
    {
        bool goIO = true;
        for (int i=0; i<img.texture.width; i++)
        {
            for (int j=0; j<img.texture.height; j++)
            {
                Color color = img.texture.GetPixel(i, j);
                if (color.a != 0)
                    goIO = false;
            }
        }
        return goIO;
    }

    void cleanFinish()
    {
        int f = findRoom();
        GlobalLogic02.curScene = f;
        if (f != -1)
            goRoom.position = new Vector3(goRoom.position.x, goRoom.position.y, -5);
        exit.position = new Vector3(exit.position.x, exit.position.y, -5);

    }

    int findRoom()
    {
        int scN = -1;
        ;
        for (int i=0; i<GlobalLogic02.totSce; i++)
        {
            if (GlobalLogic02.scR [i, 0] == GlobalLogic02.curX && GlobalLogic02.scR [i, 1] == GlobalLogic02.curY)
            {
                scN = i;
                break;
            }
        }
        return scN;
    }
    // Use this for initialization
    void Start()
    {
        img = gameObject.GetComponent<SpriteRenderer>().sprite;
        W = UnityEngine.Screen.width;
        H = UnityEngine.Screen.height;
        w = img.texture.width;
        h = img.texture.height;
        imin = Camera.main.WorldToScreenPoint(gameObject.GetComponent<SpriteRenderer>().bounds.min);
        imax = Camera.main.WorldToScreenPoint(gameObject.GetComponent<SpriteRenderer>().bounds.max);
        wS = imax.x - imin.x;
        hS = imax.y - imin.y;
       
    }    
    // Update is called once per frame
    void Update()
    {
        Vector2 cPoint = new Vector2((Input.mousePosition.x - imin.x) * w / wS, (Input.mousePosition.y - imin.y) * h / hS);
        x = cPoint.x;
        y = cPoint.y;
        if(Input.GetMouseButtonUp(1))
        {
            Debug.Log("Pressed right click.");
            for (int i=-r2; i<r2; i++)
            {
                for (int j=-(int)Mathf.Sqrt(r2*r2-i*i); j<(int)Mathf.Sqrt(r2*r2-i*i); j++)
                {
                    Color color = img.texture.GetPixel((int)(cPoint.x) + i, (int)(cPoint.y) + j);
                    img.texture.SetPixel((int)(cPoint.x) + i, (int)(cPoint.y) + j, color+new Color(0.05f,0,0.8f,0.1f));
                }
            }
            
        } 

        
        img.texture.Apply();
        gameObject.GetComponent<SpriteRenderer>().sprite = img;
    }

    void OnMouseDrag()
    {
        Vector2 cPoint = new Vector2((Input.mousePosition.x - imin.x) * w / wS, (Input.mousePosition.y - imin.y) * h / hS);
        x = cPoint.x;
        y = cPoint.y;
        if (Input.GetMouseButton(0))
        {
            for (int i=-r; i<r; i++)
            {
                for (int j=-(int)Mathf.Sqrt(r*r-i*i); j<(int)Mathf.Sqrt(r*r-i*i); j++)
                {
                    Color color = img.texture.GetPixel((int)(cPoint.x) + i, (int)(cPoint.y) + j);
                    Color C1 = new Color(color.r, color.g, color.b, 0);
                    if(color.b>0.3f)
                    img.texture.SetPixel((int)(cPoint.x) + i, (int)(cPoint.y) + j, C1);
                }
            }             

            if (inOrOut(img))
            {
                cleanFinish();
            }
        } 

     
        img.texture.Apply();
        gameObject.GetComponent<SpriteRenderer>().sprite = img;

    }
//    void OnMouseDown()
//    {
//        Vector2 cPoint = new Vector2((Input.mousePosition.x - imin.x) * w / wS, (Input.mousePosition.y - imin.y) * h / hS);
//        x = cPoint.x;
//        y = cPoint.y;
//        if (Input.GetMouseButton(1))
//        {
//            for (int i=-r; i<r; i++)
//            {
//                for (int j=-r; j<r; j++)
//                {
//                    img.texture.SetPixel((int)(cPoint.x) + i, (int)(cPoint.y) + j, Color.blue);
//                }
//            }
//            
//        } 
//        img.texture.Apply();
//        gameObject.GetComponent<SpriteRenderer>().sprite = img;
//    }
}
