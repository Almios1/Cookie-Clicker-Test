using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameMangerCookie : MonoBehaviour
{

    public Button counterClick;

    int counter = 0;
    void Start()
    {
        Button counter = counterClick.GetComponent<Button>();
        counter.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }
}
