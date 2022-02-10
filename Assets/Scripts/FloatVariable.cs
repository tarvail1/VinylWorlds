using UnityEngine;

[CreateAssetMenu(fileName = "FloatVariable", menuName = "Custom Framework/Variables/Float", order = 1)]
public class FloatVariable : ScriptableObject
{
    private float value;

    public void SetValue(float newValue)
    {
        value = newValue;
    }

    public float GetValue()
    {
        return value;
        
    }
}
