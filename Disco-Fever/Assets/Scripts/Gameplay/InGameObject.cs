using UnityEngine;

public class InGameObject : MonoBehaviour
{
    protected LevelManager LEVEL_MANAGER;

    void Start()
    {
        LEVEL_MANAGER = GameObject.FindObjectOfType<LevelManager>();
    }
}
