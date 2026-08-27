using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public List<string> items = new List<string>();

    public void AddItem(string name)
    {
        items.Add(name);
        Debug.Log("Added " + " to inventory");
    }

    public bool HasItem(string item)
    {
        return items.Contains(item);
    }

    public void RemoveItem(string item)
    {
        items.Remove(item);
    }
}
