using UnityEngine;
using System.Collections;

public class toRoom : MonoBehaviour
{

    public int scenarionum=0;
    public int curscene=1;
    public string Level="hotel01";
    // Use this for initialization
    void Start()
    {
        curscene =  GlobalLogic02.currentSceneStage [0];
        scenarionum = 0;
    
    }
    
    // Update is called once per frame
    void Update()
    {
        curscene =  GlobalLogic02.currentSceneStage [0];
    }

    void OnMouseDown()
    {
        curscene =  GlobalLogic02.currentSceneStage [0];
        scenarionum = 0;
        curScenarioStage();      
       
    }

    void curScenarioStage()
    {
		for (int i=0; i<GlobalLogic02.totSce; i++)
        {
            if (GlobalLogic02.scR [i, 0] == GlobalLogic02.curX && GlobalLogic02.scR [i, 1] == GlobalLogic02.curY)
            {
                scenarionum = i;
                curscene = GlobalLogic02.currentSceneStage [i];
				Level = "Room" + (scenarionum / 10) + (scenarionum % 10) + (curscene / 10) + (curscene % 10);
                GlobalLogic02.curMoney++;
				Application.LoadLevel(Level);

                break;
            }
        }
    }
}
