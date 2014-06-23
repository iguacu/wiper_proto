using UnityEngine;
using System.Collections;

public class toRoom : MonoBehaviour
{

    public int scenarioNum=10;
    public int curScene=10;
    public string level;
    // Use this for initialization
    void Start()
    {
    
    }
    
    // Update is called once per frame
    void Update()
    {
    
    }

    void onMouseDown()
    {
        curScenarioStage();
        level = "Room" + (scenarioNum / 10) + (scenarioNum % 10) + (curScene / 10) + (curScene % 10);
        Application.LoadLevel(level);
    }

    void curScenarioStage()
    {
        for (int i=0; i<GlobalLogic02.totSce; i++)
        {
            if (GlobalLogic02.scR [i, 0] == GlobalLogic02.curX && GlobalLogic02.scR [i, 1] == GlobalLogic02.curY)
            {
                scenarioNum = i;
                curScene = GlobalLogic02.currentSceneStage [i];

            }
        }
    }
}
