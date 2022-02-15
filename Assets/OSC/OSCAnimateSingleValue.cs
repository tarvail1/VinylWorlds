using System;
using UnityEngine;
using System.Collections;
using System.Reflection;
using UnityEngine.Rendering;

/*
 * unity script to animate a single value - works both for single-value properties (e.g., light intensity),
 * and for changing one value in a multi-valued property (currently, works for Vector3 and Color)
 */

public class OSCAnimateSingleValue : OSCAnimation
{
    public string Component;
    public string Property;
    private float multiplierValue;
    private float tempValue;

    void Start()
    {
        componentName = Component;
        propertyName = Property;
        multiplierValue = 1.0f;


        Init();
    }

    // Update is called once per frame
    void Update()
    {
        if (newMessage)
        {
            try
            {
                if (!isMultiValue)
                {
                    // we directly set the value if the property is single-value
                    if (property == null)
                    {
                        if ((int) localMsg.Values[1]==1)
                        {
                            multiplierValue = 2;
                        }
                        else
                        {
                            multiplierValue = map((int) localMsg.Values[0], 60, 66, -8f, 8f);
                        }

                        field.SetValue(comp, multiplierValue);
                    }
                }
            }
            catch (System.Exception e)
            {
                Debug.Log(
                    "Wrong propertyname, or missing component, or type mismatch between message value and property value");
            }

            newMessage = false;
        }
    }


    // c#
    float map(float s, float a1, float a2, float b1, float b2)
    {
        return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
    }
}