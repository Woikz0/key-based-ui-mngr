using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    private Dictionary<string, Delegate> actionList = new();

    private void Awake()
    {
        Instance = this;
    }

    public void AddAction<T>(string key, UnityAction<T> action)
    {
        actionList.Add(key, action);
    }

    public void ExecuteAction<T>(string key, T parameter)
    {
        if (actionList.ContainsKey(key))
        {
            actionList[key].DynamicInvoke(parameter);
        }
        else throw new NotImplementedException("key could not found");
    }
}
