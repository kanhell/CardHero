using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hp;
    public int mp;

    // 버프 : 기본 1
    public float attackBuff;
    public float defenseBuff;


    void Start()
    {
        attackBuff = 1;
        defenseBuff = 1;
    }

    public GameObject TargetSelect()
    {
        GameObject target = GameManager.instance.MonsterSelect();
        return target;
    }

   
    public void PlayerTurn()
    {
        // animation (just log "my turn")
        // get card
        // GameManager.instance.CheckState();  // until end (1. nomore deck  2. end button clicked  3. die  4. victory)
        // card select & apply
        GameObject target = TargetSelect();
    }

    void Attack(int damage, GameObject target)
    {
        float calDamage = damage * attackBuff;
        MonsterController targetController = target.GetComponent<MonsterController>();
        targetController.Damaged(calDamage);
    }

    void Damaged(int damage)
    {
        float calDamage = damage * defenseBuff;
        hp -= calDamage;
        // 죽었는지 확인
        if (hp < 0)
            GameManager.instance.GameOver();
    }

    public void EndTurn()
    {
        GameManager.instance.GameOver();
    }
}
