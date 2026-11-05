using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int exPerKill = 35;
    public int totalDamage = 250;
    public int Hits = 20;
    public float expRate = 1.5f;

    [ContextMenu("정산")]
    void Settle()
    {
        int min = playSeconds / 60;
        int sec = playSeconds % 60;
        int hours = min / 60;
        Debug.Log(hours + ":" + min + ":" + sec);

        int memberPerGold = gold / members;
        Debug.Log("1인당 " + memberPerGold + "G");

        int readerBonus = gold % members;
        Debug.Log("리더 보너스" + readerBonus + "G");

        int EXP = kills * exPerKill;
        Debug.Log("기본 경험치 : " + EXP);
        int exp = (int)(EXP * expRate);
        Debug.Log("경험치 : " + exp);

        int level = (EXP / 100)+1;

        int currentLevel = 100 - (EXP % 100);
        Debug.Log("Lv" + level  + ",다음 레벨까지 " + currentLevel);

        float Damage = (float)totalDamage / Hits;
        Debug.Log("평균 데미지 : " + Damage);
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
