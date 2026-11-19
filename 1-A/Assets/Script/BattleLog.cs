using UnityEngine;
using System.Collections.Generic;


public class BattleLog : MonoBehaviour
{
    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;

    [ContextMenu("전투 기록")]
    public void ShowBattleLog()
    {
        List<int> criticals = new List<int>();
       
        int sum = 0;
        foreach (int damage in damages)
        {
            sum += damage;
            if (damage >= criticalLine)
            {
                criticals.Add(damage);
            }
        }
        Debug.Log("총 데미지 : " + sum);
        Debug.Log("치명타 횟수 : " + criticals.Count);
        foreach (int crit in criticals)
        {
            Debug.Log("치명타 : " + crit);
        }
    }
}
