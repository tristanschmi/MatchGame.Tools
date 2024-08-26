<<<<<<< HEAD
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;
}
=======
using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;

    public void SetValue(float num)
    {
        value = num;
    }

    public void UpdateValue(float num)
    {
        value += num;
    }
}
>>>>>>> 468da88795b4ef8f581e04cd049cfc86140cd065
