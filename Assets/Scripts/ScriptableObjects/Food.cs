using UnityEngine;
using UnityEngine.UI;
public enum typeFood{
    healthy,
    unhealthy
}

public class Food : ScriptableObject
{
    public string nameFood;
    public Sprite imageFood;
    public string descriptionFood;
}
