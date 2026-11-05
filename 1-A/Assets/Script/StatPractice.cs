using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string PlayerName = "Player";
    public int Level = 10;
    public float attack = 5.0f;
    public bool isBoss = false;

    [ContextMenu("스탯")]

    void ShowStat()
    {
        Debug.Log(PlayerName);
        Debug.Log(Level);
        Debug.Log(attack);
        Debug.Log(isBoss);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
