using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void CheckState()
    {

    }

    public GameObject MonsterSelect()
    {
        // 몬스터 선택 (몬스터는 버튼)
    }

    public void GameOver()
    {

    }

    public void Victory()
    {

    }
}
