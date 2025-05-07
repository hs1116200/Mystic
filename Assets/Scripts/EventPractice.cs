using UnityEngine;
using UnityEngine.Events;

public class EventPractice : MonoBehaviour
{
    public UnityEvent textEvent = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        textEvent.AddListener(TextListener);    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) { textEvent.Invoke(); }
    }

    void TextListener() { print("TestListener called"); }
}
