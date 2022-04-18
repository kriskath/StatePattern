using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//sealed keyword makes it so other classes cannot inherit from this class
public sealed class GameEnvironment : MonoBehaviour
{
    private static GameEnvironment instance;

    public static GameEnvironment Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new GameEnvironment();
                instance.FindCheckpoints();
            }
            return instance;
        }
    }

    private List<GameObject> checkpoints;
    public List<GameObject> GetCheckpoints() => checkpoints;


    private void FindCheckpoints()
    {
        checkpoints.AddRange(GameObject.FindGameObjectsWithTag("Checkpoint"));
    }

}
