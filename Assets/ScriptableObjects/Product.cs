using UnityEngine;

[CreateAssetMenu(fileName = "Product", menuName = "Product/New Product")]
public class Product : ScriptableObject
{
    public string name;
    public Sprite image;
    public float basePrice;
    public float marmeladePerSecond;
}
