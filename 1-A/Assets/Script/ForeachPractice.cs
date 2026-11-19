using UnityEngine;

public class ForeachPractice : MonoBehaviour
{
    public int[] monsterHps = { 0, 35, 80, 12 };
    [ContextMenu("foreach 실습")]
    public void CountAlive()
    {
        int count = 0;
        int sum = 0;
        foreach (int Hp in monsterHps)
        {
            if (Hp > 0)
            {
                count++;
                sum += Hp;
            }
        }
        Debug.Log("몬스터의 수" + count + "마리");
        Debug.Log("남은 체력의 합" + sum);
    }
}
