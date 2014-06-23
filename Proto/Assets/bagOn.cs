using UnityEngine;
using System.Collections;

public class bagOn : MonoBehaviour {

    static bagOn _instance;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void onMouseDown()
    {
        //boxcomponent transform.z -5로
    }
    public void Awake()
    {
        // 씬이 변경되어도 제거되지 않도록 설정
        DontDestroyOnLoad(gameObject);
    }
    
    public static bagOn Instance
    {
        get
        {
            if (_instance == null)
            {
                // 현재 씬 내에서 GameManager 컴포넌트를 검색
                _instance = FindObjectOfType(typeof(bagOn)) as bagOn;
                if (_instance == null)
                {
                    // 현재 씬에 GameManager 컴포넌트가 없으면 새로 생성
                    _instance = new GameObject("Game Manager", typeof(bagOn)).GetComponent<bagOn>();
                }
            }            
            return _instance;
        }
    }
}
