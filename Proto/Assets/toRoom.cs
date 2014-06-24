using UnityEngine;
using System.Collections;

public class toRoom : MonoBehaviour
{

    public int scenarionum=5;
    public int curscene=5;
    public string Level="hotel01";
    // Use this for initialization
    void Start()
    {
    
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        curscene = GlobalLogic02.curX;
        scenarionum = GlobalLogic02.scR [0, 0];
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
				Application.LoadLevel(Level);
                break;
            }
        }
    }
}
