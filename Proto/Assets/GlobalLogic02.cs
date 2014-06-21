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
    static int dayMax = 15;
    int timespeed = 100;
    static Sprite[] dayImg = new Sprite[10];
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
    string [][][] scenario;
    //Scenariio 1
    static public bool s1On = false;
    string[][] clues;

    //dontDestroy
    static GlobalLogic02 _instance;
//    void setScenario()
//    {
//        scenario=new string[totSce][][];
//
//    }
//    void setInScenario(int i)
//    {
//        scenario[i]=new 
//    }
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
        int mon01 = curMoney/ 10;
        int mon02 = curMoney % 10;
        if (curMoney >= 0&&Application.loadedLevelName == "hotel01") {
			GameObject.Find ("Score_Money_Num01").GetComponent<SpriteRenderer> ().sprite = dayImg [mon01];
			GameObject.Find ("Score_Money_Num02").GetComponent<SpriteRenderer> ().sprite = dayImg [mon02];
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
    static void randomScene1Window()
    {
        if (Application.loadedLevelName == "hotel01")
        {
            for (int i=0; i<wX; i++)
            {
                for (int j=0; j<wY; j++)
                {
                    GameObject.Find("Window " + (j + 1) + "0" + (i + 1)).GetComponent<SpriteRenderer>().sprite = windowN1;
                }
            }
            for (int i=0; i<totSce; i++)
            {
                scR [i, 0] = (int)(Random.value * wX);
                scR [i, 1] = (int)(Random.value * wY);
                GameObject.Find("Window " + (scR [i, 1] + 1) + "0" + (scR [i, 0] + 1)).GetComponent<SpriteRenderer>().sprite = windowQ1;
            }
        }
    }
    // Use this for initialization
    void Start()
    {
        windowQ1 = windowQ;
        windowN1 = windowN;    
        curTime = 0;
        curMoney = 0;
        Sprite[] textures = Resources.LoadAll<Sprite>("Objects/Days");
        totSceneStage [0] = 5;
        for(int i=0;i<totSce;i++)
        currentSceneStage [i] = 0;
        for (int i=0; i<wX; i++)
        {
            for (int j=0; j<wY; j++)
            {
                window [i, j] = GameObject.Find("Window " + (j + 1) + "0" + (i + 1)).transform;
            }
        }
        for (int i=0; i<totSce; i++)
        {
            currentSceneStage [i] = 0;
        }
        randomScene1Window(); 
        for (int i=0; i<10; i++)
        {
            dayImg [i] =textures [i];
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
		decimalMinute ();
        decimalMoney();
        if (min >= 60)
        {
            min = 0;
            curTime = min;
            hour++;
			decimalHour();
        }
        m = min;
        h = hour;
        d = day;
        mo = curMoney;
        if (h >= 18)
            nextDay();
    }
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