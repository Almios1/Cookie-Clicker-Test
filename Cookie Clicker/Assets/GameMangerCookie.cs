using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameMangerCookie : MonoBehaviour
{

    public Button counterClick;
    public Button oneHandClick;

    float counter = 0;
    float clickAmount = 1F;

    [SerializeField]
    private Text counterText;

    [SerializeField]
    private GameObject oneHand;

    void Start()
    {
        oneHand.gameObject.SetActive(false);
        
        

    }

    public void TaskOnClick()
    {
        counter += clickAmount;
        counterText.text = ("Counter: " + counter.ToString("F2"));
    }
    public void oneHand2()
    {
        counter = counter - 100;
        clickAmount += 0.2F;
        counterText.text = ("Counter: " + counter.ToString("F2"));
    }

    void Update()
    {
        if(counter >= 100)
        {
            oneHand.gameObject.SetActive(true);
        }
        else
        {
            oneHand.gameObject.SetActive(false);
        }
    }

}
