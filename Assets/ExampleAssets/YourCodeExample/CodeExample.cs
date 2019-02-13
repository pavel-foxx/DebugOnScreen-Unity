using DebugOnScreen;
using System.Collections.Generic;
using UnityEngine;

public class CodeExample : MonoBehaviour
{
    private List<int> activeNums = new List<int>();

    public void ActivateNum(int num)
    {
        if (!activeNums.Contains(num))
        {
            activeNums.Add(num);
            Debuger.Log($"The Num {num} activated!");
        }
        else
        {
            Debuger.Log($"Activate Error. The Num {num} is already active!");
        }
    }

    public void DeactivateNum(int num)
    {
        if (activeNums.Contains(num))
        {
            activeNums.Remove(num);
            Debuger.Log($"The Num {num} deactivated!");
        }
        else
        {
            Debuger.Log($"Deactivate Error. The Num {num} is not active!");
        }
    }

    public void UseNum(int num)
    {
        if (activeNums.Contains(num))
        {
            Debuger.Log($"The Num {num} used!");
        }
        else
        {
            Debuger.LogError($"Use Error. The Num {num} is not avaible!");
        }
    }
    
}
