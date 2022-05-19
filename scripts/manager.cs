
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum MyScenes
{
    welcome,
    main,
    end
}

public class manager : MonoBehaviour
{
    public InputField ipfKidsName;
    private SoRuntimeData runtimeData;
    public Text displayKidsName;
    public void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KAddiererRuntimeData");

        if (SceneManager.GetActiveScene().buildIndex == (int)MyScenes.welcome)
        {
            displayKidsName.text = runtimeData.nameKid;

        }
    }
    public void SwitchTheScene(int x)
    {
        SceneManager.LoadScene(x);
    }
}









