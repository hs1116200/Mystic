using UnityEngine;
using UnityEngine.UI;

public class SeedCount : MonoBehaviour
{
    [SerializeField] public Text seedDisplay;
    public int seedCount;

    public int Seeds
    {
        get{return seedCount;}
        set{seedCount = value;}
    }

    // Start is called before the first frame update
    void Start()
    {
        seedCount = 0;
        seedDisplay.text = "Seeds: " + seedCount;
    }

    public void UpdateCount(int count)
    {
        seedCount += count;
        seedDisplay.text = "Seeds: " + seedCount;
    }
}
