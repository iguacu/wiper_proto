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
    //TestNum
    public float m;
    public float h;
    public int mo = 0;
    //Scenario
    static public int totSce=1;
    static public int[,] scR = new int[totSce, 2];
    static public int[] currentSceneStage=new int[totSce];
    static public int curScene=0;
    public Sprite windowQ;// Resources.Load("fruits_1", typeof(Sprite)) as Sprite
    public Sprite windowN;
    //Scenariio 1
    static public bool s1On = false;
    void GameOver()
    {
        
    }
    
    void randomScene1Window()
    {
        for (int i=0; i<totSce; i++)
        {
            scR [i, 0] = (int)(Random.value * wX);
            scR [i, 1] = (int)(Random.value * wY);
            GameObject.Find("Window " + (scR[i,1] + 1) + "0" + (scR[i,0] + 1)).GetComponent<SpriteRenderer>().sprite=windowQ;

        }
    }
    // Use this for initialization
    void Start()
    {
    
        curTime = 0;
        curMoney = 0;
        for (var i=0; i<2; i++)
        {
            for (var j=0; j<2; j++)
            {
                window [i, j] = GameObject.Find("Window " + (j + 1) + "0" + (i + 1)).transform;
            }
        }
        for (int i=0; i<totSce; i++)
        {
            currentSceneStage[i]=0;
        }
        randomScene1Window();
    }
        // Update is called once per frame
    void Update()
    {
        time();

    }
    void time()
    {
        curTime += Time.deltaTime * 3;
        min = (int)curTime;
        if (min >= 60)
        {
            curTime = 0;
            hour++;
        }
        m = scR[0,0];
        h = scR[0,1];
        mo = curMoney;
        if(h>=20)
            nextDay();
    }
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

    void nextDay()
    {
        day++;
        curTime = 0;
        hour = 8;
        curMoney -= 3;
        if (curMoney < 0)
            GameOver();
        randomScene1Window();
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