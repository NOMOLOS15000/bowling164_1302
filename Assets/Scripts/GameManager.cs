using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    private Bowling bowling;

    private void Awake()
    {
        instance = this;
    }


    public void addpoint(int i)
    {
        bowling.point += i;
    }
}
