using System;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Instance
    public static GameManager instance;
    // Collectable data
    private int stringnum = 0; private int coinnum = 0;
    // List of collected items
    public List<string> collectedItems = new List<string>();
    // Eventos para la UI
    public UnityEvent<int> ganarCuerda;
    public UnityEvent<int> ganarMoneda;
    // Conditions
    private bool Mus = false;
    private void Awake()
    {
        if (instance != null) { Debug.Log("Another instance present"); Destroy(this); }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        UpdateGUI();
    }
    private void UpdateGUI()
    {
        // Collectables
        // Strings
        ganarCuerda.Invoke(stringnum);
        // Coins
        ganarMoneda.Invoke(coinnum);
    }
    public void GainObject(string obj)
    {
        string objID = SceneManager.GetActiveScene().name + "_" + obj;
        if (!collectedItems.Contains(objID))
        {
            collectedItems.Add(objID);
        }
        switch (obj)
        {
            case "String": stringnum++; break;
            case "Coin": coinnum++; break;
            default: Debug.LogWarning("Unknown object"); break;
        }
        UpdateGUI();
    }
    public int GetCount(string obj)
    {
        switch (obj)
        {
            case "String": return stringnum;
            case "Coin": return coinnum;
            default: Debug.LogWarning("No object with that name to return value"); return -1; 
        }
    }
    public bool HasMus()
    {
        return Mus;
    }
    public void RemoveCoin()
    {
        coinnum = 0;
        UpdateGUI();
    }
}