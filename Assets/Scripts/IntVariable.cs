using UnityEngine;

[CreateAssetMenu(fileName = "IntVariable", menuName = "Custom Framework/Variables/Int", order = 1)]
public class IntVariable : ScriptableObject
{
    private int value;

    public void SetValue(int newValue)
    {
        value = newValue;
    }

    public int GetValue()
    {
        return value;
        
    }
}
