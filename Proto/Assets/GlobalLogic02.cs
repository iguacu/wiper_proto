using UnityEngine;
using System.Collections;

public class GlobalLogic02 : MonoBehaviour
{
    //Static Time/Money/Window;
    static public float curTime;
    static public int curMoney;
    static public int day = 1;
    static public int hour = 8;
    static public int min = 0;
    static public int wX = 2;
    static public int wY = 2;
    static public int curX;
    static public int curY;
    static public Transform[,] window = new Transform[wX, wY];
    static int dayMax=15;
    int timespeed=100;
    static Sprite[] dayImg = new Sprite[10];
    //TestNum
    public float m;
    public float h;
    public int d;
    public int mo = 0;
    //Scenario
    static public int totSce=1;
    static public int[,] scR = new int[totSce, 2];
    static public int[] currentSceneStage=new int[totSce];
    static public int[] totSceneStage=new int[totSce];
    static public int curScene=0;
    public Sprite windowQ;// Resources.Load("fruits_1", typeof(Sprite)) as Sprite
    public Sprite windowN;

    static public Sprite windowQ1;// Resources.Load("fruits_1", typeof(Sprite)) as Sprite
    static public Sprite windowN1;
    //Scenariio 1
    static public bool s1On = false;

    static void decimalDay()
    {
        int day01=9;
        int day02 = 1;
            day01=day/10+8;
        day02 = day % 10;
        GameObject.Find("Score_Day_Num_01").GetComponent<SpriteRenderer>().sprite = dayImg [day01];
        GameObject.Find("Score_Day_Num_02").GetComponent<SpriteRenderer>().sprite = dayImg [day02];

    }

    static void GameOver(int gameCoef)
    {
        if (gameCoef == 0)
        {
            //Gameover
        } else
        {//Ending
        
        }
    }
    
    static void randomScene1Window()
    {
        for (int i=0; i<totSce; i++)
        {
            scR [i, 0] = (int)(Random.value * wX);
            scR [i, 1] = (int)(Random.value * wY);
            GameObject.Find("Window " + (scR[i,1] + 1) + "0" + (scR[i,0] + 1)).GetComponent<SpriteRenderer>().sprite=windowQ1;

        }
    }
    // Use this for initialization
    void Start()
    {
        windowQ1 = windowQ;
        windowN1 = windowN;
    
        curTime = 0;
        curMoney = 0;
        for (int i=0; i<wX; i++)
        {
            for (int j=0; j<wY; j++)
            {
                window [i, j] = GameObject.Find("Window " + (j + 1) + "0" + (i + 1)).transform;
            }
        }
        for (int i=0; i<totSce; i++)
        {
            currentSceneStage[i]=0;
        }
        randomScene1Window();
        for (int i=0; i<10; i++)
        {
            dayImg[i]=Resources.Load<Sprite>("Resouces/Objects/Days/0.png");


        }
    }
        // Update is called once per frame
    void Update()
    {
        time();

    }
    void time()
    {
        curTime += Time.deltaTime * timespeed;
        min = (int)curTime;
        if (min >= 60)
        {
            min=0;
            curTime = min;
            hour++;
        }
        m = min;
        h = hour;
        d = day;
        mo = curMoney;
        if(h>=20)
            nextDay();
    }
//    static public void timeEx()
//    {
//        curTime += Time.deltaTime * 3;
//        min = (int)curTime;
//        if (min >= 60)
//        {
//            curTime = 0;
//            hour++;
//        }
//        m = min;
//        h = hour;
//
//        if(hour>=20)
//            nextDay();
//    }

    static GlobalLogic02 _instance;
    
    public void Awake()
    {
        // 씬이 변경되어도 제거되지 않도록 설정
        DontDestroyOnLoad(gameObject);
    }
    
    public static GlobalLogic02 Instance
    {
        get
        {
            if (_instance == null)
            {
                // 현재 씬 내에서 GameManager 컴포넌트를 검색
                _instance = FindObjectOfType(typeof(GlobalLogic02)) as GlobalLogic02;
                if (_instance == null)
                {
                    // 현재 씬에 GameManager 컴포넌트가 없으면 새로 생성
                    _instance = new GameObject("Game Manager", typeof(GlobalLogic02)).GetComponent<GlobalLogic02>();
                }
            }
            
            return _instance;
        }
    }

    static public void nextDay()
    {
        day++;
        decimalDay();
        curTime = 0;
        hour = 8;
        curMoney -= 3;
        if (curMoney < 0)
            GameOver(0);
        randomScene1Window();
        if (day >= dayMax)
            GameOver(1);
    }


}



//static var time;
//static var money;

//function Start () {
//  money=0;
//  time=0;
//  for(var i=0;i<2;i++)
//  {
//      for(var j=0;j<2;j++)
//      {
//          window[i,j]=GameObject.Find("Window "+(j+1)+"0"+(i+1)).transform;
//      }
//  }
//}
//
//function Update () {
//  time+=Time.deltaTime;
//}