using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootUI : MonoBehaviour {

    public GameObject canvas_main;
    public GameObject canvas_lobby;
    public GameObject canvas_loading;
    public GameObject canvas_setting;

    public int sel_cnt;
    public int test;

    // Use this for initialization
    void Start ()
    {
        Debug.Log(test);
        sel_cnt = 0;
        if(test == 4)
        {
            InvokeRepeating("onTimer", 1.0f, 1.0f);
        }
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void onTimer()
    {
        int cnt = canvas_lobby.GetComponent<rootUI>().sel_cnt;
        if(cnt>0)
            Debug.Log(cnt);
    }
    public void OnBtnStart()
    {
        canvas_lobby.SetActive(true);

        canvas_main.SetActive(false);
        canvas_loading.SetActive(false);
        canvas_setting.SetActive(false);
    }
    public void OnBtnSetting()
    {
        canvas_setting.SetActive(true);

        canvas_main.SetActive(false);
        canvas_loading.SetActive(false);
        canvas_lobby.SetActive(false);
    }
    public void OnBtnQuit()
    {
        Debug.Log("Quit~!!");
    }

    public void OnBtnBacklobby()
    {
        canvas_main.SetActive(true);

        canvas_loading.SetActive(false);
        canvas_setting.SetActive(false);
        canvas_lobby.SetActive(false);
    }
    public void OnBtnBackSetting()
    {
        canvas_main.SetActive(true);

        canvas_loading.SetActive(false);
        canvas_setting.SetActive(false);
        canvas_lobby.SetActive(false);
    }

    public void OnBtnSel1()
    {
        canvas_loading.SetActive(true);
        sel_cnt = 1;
        canvas_main.SetActive(false);
        canvas_setting.SetActive(false);
        canvas_lobby.SetActive(false);
    }
    public void OnBtnSel2()
    {
        canvas_loading.SetActive(true);
        sel_cnt = 2;
        canvas_main.SetActive(false);
        canvas_setting.SetActive(false);
        canvas_lobby.SetActive(false);
    }
    public void OnBtnSel3()
    {
        canvas_loading.SetActive(true);
        sel_cnt = 3;
        canvas_main.SetActive(false);
        canvas_setting.SetActive(false);
        canvas_lobby.SetActive(false);
    }
}
