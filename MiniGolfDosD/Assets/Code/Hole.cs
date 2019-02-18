using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    [SerializeField]
    private string nextScene;

    public string GetNextScene()
    {
        return this.nextScene;
    }
}
