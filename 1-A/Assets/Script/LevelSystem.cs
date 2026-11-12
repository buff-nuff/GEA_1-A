using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int expPerKill = 35000;
    public int killCount = 3;
    [ContextMenu("레벨 계산")]
    void CalculateLevel()
    {
        int level = 1;
        int exp = 0;
        
        exp = expPerKill * killCount;
       
        while (exp >= level * 10000)
        {
            exp -= level * 10000;
            level++;
            Debug.Log("레벨업! Lv " + level + "( " + killCount + "마리 째)");
        }
    }
}
