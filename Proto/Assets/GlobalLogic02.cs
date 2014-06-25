using UnityEngine;
using System.Collections;

public class GlobalLogic02 : MonoBehaviour
{
    //Static Time/Money/Window;
    static public float curTime=0;
    static public int curMoney=0;
    static public int day = 1;
    static public int hour = 10;
    static public int min = 0;
    static public int wX = 6;
    static public int wY = 9;
    static public int curX;
    static public int curY;
    static public Transform[,] window = new Transform[wX, wY];
    static public int test=1;
    static int dayMax = 15;
    int timespeed = 10;
    static Sprite[] dayImg = new Sprite[10];
    static public bool[,] windowT = new bool[wX, wY];
    static public bool[,] passT= new bool[wX, wY];
    static public string note="";
    //TestNum
    public float m;
    public float h;
    public int d;
    public int mo = 0;
    //Scenario
    static public int totSce = 1;
    static public int[,] scR = new int[totSce, 2];
    static public int[] currentSceneStage = new int[totSce];
    static public int[] totSceneStage = new int[totSce];
    static public int curScene = 0;
    public Sprite windowQ;// Resources.Load("fruits_1", typeof(Sprite)) as Sprite
    public Sprite windowN;
    static public Sprite windowQ1;// Resources.Load("fruits_1", typeof(Sprite)) as Sprite
    static public Sprite windowN1;
    static string[][][] scenarioItems;
    static int[][] numOfItems;
    //Scenariio 1
    static public bool s1On = false;
    static public string[][] clues;
    public static string nameofActor="";

    //dontDestroy
    private static GlobalLogic02 _instance;

    void setScenario()
    {
        scenarioItems = new string[totSce][][];
        numOfItems = new int[totSce][];
        //Scenario1
        numOfItems [0] = new int[totSceneStage [0]];//5
        scenarioItems [0] = new string[totSceneStage [0]][];
        numOfItems [0] [0] = 1;
        numOfItems [0] [1] = 3;
        numOfItems [0] [2] = 2;
        numOfItems [0] [3] = 1;
        for (int i=0; i<totSceneStage[0]; i++)
            scenarioItems [0] [i] = new string[numOfItems [0] [i]];
        scenarioItems [0] [0] [0] = "letter";
        scenarioItems [0] [1] [0] = "A";
        scenarioItems [0] [1] [1] = "M";
        scenarioItems [0] [1] [2] = "Y";
        scenarioItems [0] [2] [0] = "name";
        scenarioItems [0] [2] [1] = "ID";
        scenarioItems [0] [1] [0] = "cloth";
        //Scenario2
    }

    static void decimalDay()
    {
        int day01 = day / 10;
        int day02 = day % 10;
        if (Application.loadedLevelName == "hotel01")
        {
            GameObject.Find("Score_Day_Num01").GetComponent<SpriteRenderer>().sprite = dayImg [day01];
            GameObject.Find("Score_Day_Num02").GetComponent<SpriteRenderer>().sprite = dayImg [day02];
        }
    }

    static void decimalMoney()
    {
        int mon01 = curMoney / 10;
        int mon02 = curMoney % 10;
        if (curMoney >= 0 && Application.loadedLevelName == "hotel01")
        {
            GameObject.Find("Score_Money_Num01").GetComponent<SpriteRenderer>().sprite = dayImg [mon01];
            GameObject.Find("Score_Money_Num02").GetComponent<SpriteRenderer>().sprite = dayImg [mon02];
        }
    }

    static void decimalHour()
    {
        int hour01 = hour / 10;
        int hour02 = hour % 10;
        if (Application.loadedLevelName == "hotel01")
        {
            GameObject.Find("Score_Time_Num01").GetComponent<SpriteRenderer>().sprite = dayImg [hour01];
            GameObject.Find("Score_Time_Num02").GetComponent<SpriteRenderer>().sprite = dayImg [hour02];
        }
    }

    static void decimalMinute()
    {
        int min01 = min / 10;
        int min02 = min % 10;
        if (Application.loadedLevelName == "hotel01")
        {
            GameObject.Find("Score_Time_Num03").GetComponent<SpriteRenderer>().sprite = dayImg [min01];
            GameObject.Find("Score_Time_Num04").GetComponent<SpriteRenderer>().sprite = dayImg [min02];
        }
    }

    static void GameOver(int gameCoef)
    {
        if (gameCoef == 0)
        {
            //Gameover
        } else
        {
            //Ending      
        }
    }
    static public void loadWindow()
    {
        for (int i=0; i<wX; i++)
        {
            for (int j=0; j<wY; j++)
            {
                if(passT[i,j])
                    window [i, j] = GameObject.Find("Window " + (j + 1) + "0" + (i + 1)).transform;
            }
        }
        if (Application.loadedLevelName == "hotel01")
        {
            for (int i=0; i<wX; i++)
            {
                for (int j=0; j<wY; j++)
                {
                    if(windowT[i,j])
                        GameObject.Find("Window " + (j + 1) + "0" + (i + 1)).GetComponent<SpriteRenderer>().sprite = windowN1;
                }
            }
            for (int i=0; i<totSce; i++)
            {
                if(windowT[scR [i, 0],scR [i, 1]])                 
                GameObject.Find("Window " + (scR [i, 1] + 1) + "0" + (scR [i, 0] + 1)).GetComponent<SpriteRenderer>().sprite = windowQ1;
            }
        }
    }
    static void randomScene1Window()
    {
            for (int i=0; i<totSce; i++)
        {
            scR [i, 0] = (int)(Random.value * wX);
            scR [i, 1] = (int)(Random.value * wY);
        }

    }
    // Use this for initialization
    void Start()
    {
        Debug.Log("Start");
        windowQ1 = windowQ;
        windowN1 = windowN;    
        for (int i=0; i<wX; i++)
        {
            for(int j=0;j<wY;j++)
                windowT[i,j]=true;
        }
        windowT [0, 8] = false;
        windowT [1, 8] = false;
        windowT [4, 8] = false;
        windowT [5, 8] = false;        
        windowT [2, 0] = false;
        windowT [2, 1] = false;
        windowT [2, 2] = false;
        windowT [3, 0] = false;
        windowT [3, 1] = false;
        windowT [3, 2] = false;
        for (int i=0; i<wX; i++)
        {
            for(int j=0;j<wY;j++)
                passT[i,j]=true;
        }
        passT [0, 8] = false;
        passT [1, 8] = false;
        passT [4, 8] = false;
        passT [5, 8] = false;        
        
        Sprite[] textures = Resources.LoadAll<Sprite>("Objects/Days");
        totSceneStage [0] = 5;
        for (int i=0; i<totSce; i++)
            currentSceneStage [i] = 0;
       
        for (int i=0; i<totSce; i++)
        {
            currentSceneStage [i] = 0;
        }
        randomScene1Window(); 
        for (int i=0; i<10; i++)
        {
            dayImg [i] = textures [i];
        }
        time();
    }
    // Update is called once per frame
    void Update()
    {
        time();


    }

    void time()
    {

        if (Application.loadedLevelName == "hotel01")
            loadWindow();
        curTime = curTime+Time.deltaTime * timespeed;
        test++;
        min = (int)curTime;

        if (min >= 60)
        {
            min = min-60;
            curTime = min;
            hour++;

        }
        m = min;
        h = hour;
        d = day;
        mo = curMoney;
        if (h >= 18)
            nextDay();
        decimalHour();
        decimalMinute();
        decimalMoney();
    }

    void Awake()
    {
        if (_instance)
        {
            Destroy (gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad (gameObject);
        }
        Debug.Log("Awake");
        // 씬이 변경되어도 제거되지 않도록 설정

       
    }


       
      


//    public static GlobalLogic02 Instance
//    {
//        get
//        {
//            if (_instance == null)
//            {
//                // 현재 씬 내에서 GameManager 컴포넌트를 검색
//                GameObject GM = GameObject.Find("GM 오브젝트 이름");
//                
//                if(Gm == null)
//                {
//                    gm 새로 만들고 gm의 인스턴스를 _instance에 대입
//                }
//                
//                else
//                {
//                    _instace 반환
//                }
//                
//                
//            }            
//            return _instance;
//        }
//    }
    static public void nextDay()
    {
        day++;
        decimalDay();
        curTime = 0;
        hour = 10;
        min = 0;
        curMoney -= 3;
        if (curMoney < 0)
            GameOver(0);
        randomScene1Window();
        if (day >= dayMax)
            GameOver(1);
    }
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