using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameMangerCookie : MonoBehaviour
{

    public Button counterClick;


    float counter = 0;
    float clickAmount = 1.2F;

    [SerializeField]
    private Text counterText;

    void Start()
    {
        Button counter = counterClick.GetComponent<Button>();
        counter.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        counter += clickAmount;
        Debug.Log(counter);
       
        counterText.text = ("Counter: " + counter.ToString("F2"));
    }
}
