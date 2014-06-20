using UnityEngine;
using System.Collections;

public class windowClean : MonoBehaviour
{

    int r = 100;
    bool tf = false;
    string Level = "Room 01";
    public float x, y;
    public Transform goRoom;
    public Transform exit;

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
        GameObject.Find("Window " + (GlobalLogic02.curX + 1) + "0" + (GlobalLogic02.curY + 1)).GetComponent<SpriteRenderer>().sprite=GlobalLogic02.windowN1;
        if (f != -1)
            goRoom.position = new Vector3(goRoom.position.x, goRoom.position.y, -5);
        exit.position = new Vector3(exit.position.x, exit.position.y, -5);
        GlobalLogic02.curMoney++;
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
    
    }

    
    // Update is called once per frame
    void Update()
    {
        Sprite img = gameObject.GetComponent<SpriteRenderer>().sprite;
        Vector3 im = Camera.main.WorldToScreenPoint(transform.position);
        var W = UnityEngine.Screen.width;
        var H = UnityEngine.Screen.height;
        var w = img.texture.width;
        var h = img.texture.height;
        Vector2 im2 = new Vector2(im.x - w / 2, im.y - h / 2);
        Vector2 cPoint = new Vector2(Input.mousePosition.x - im2.x, Input.mousePosition.y - im2.y);

        if (Input.GetMouseButtonDown(0))
        {
            for (int i=-r; i<r; i++)
            {
                for (int j=-r; j<r; j++)
                {

                    Color color = img.texture.GetPixel((int)(cPoint.x) + i, (int)(cPoint.y) + j);
                    Color C1 = new Color(color.r, color.g, color.b, 0);
                    img.texture.SetPixel((int)(cPoint.x) + i, (int)(cPoint.y) + j, C1);
                }
            }
            x = img.texture.GetPixel((int)(cPoint.x), (int)(cPoint.y)).a;
            y = img.texture.GetPixel((int)(cPoint.x), (int)(cPoint.y)).r;
            img.texture.Apply();
            gameObject.GetComponent<SpriteRenderer>().sprite = img;
            if (inOrOut(img))
            {
                cleanFinish();
            }
        }
    }


}