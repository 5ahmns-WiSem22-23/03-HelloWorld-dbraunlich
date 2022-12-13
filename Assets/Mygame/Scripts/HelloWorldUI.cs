using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HelloWorldUI : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] TextMeshProUGUI text;

    void Awake()
    {
        text.gameObject.SetActive(false);
    }
    
    public void ShowText()
    {
        text.text = inputField.text;
        if (!text.gameObject.activeSelf) text.gameObject.SetActive(true);
    }
}