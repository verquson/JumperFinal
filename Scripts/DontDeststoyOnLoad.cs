using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDeststoyOnLoad : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
