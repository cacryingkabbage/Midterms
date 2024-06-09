using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public TextMeshProUGUI eggScore;
    public TextMeshProUGUI chickScore;
    public TextMeshProUGUI henScore;
    public TextMeshProUGUI roosterScore;

    public static int eggCount = 0;
    public static int chickCount = 0;
    public static int henCount = 0;
    public static int roosterCount = 0;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateEggScore(int val)
    {
        eggCount += val;
        eggScore.text = "EGGS: " + string.Format(eggCount.ToString());
    }
    public void UpdateChickScore(int val)
    {
        chickCount += val;
        chickScore.text = "CHICKS: " + string.Format(chickCount.ToString());
    }
    public void UpdateHenScore(int val)
    {
        henCount += val;
        henScore.text = "HENS: " + string.Format(henCount.ToString());
    }
    public void UpdateRoosterScore(int val)
    {
        roosterCount += val;
        roosterScore.text = "ROOSTERS: " + string.Format(roosterCount.ToString());
    }

    public static int ChickCount { get { return chickCount; } }
}
