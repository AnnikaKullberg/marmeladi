using UnityEngine;
using UnityEngine.UI;

public class ProductButton : MonoBehaviour
{
    [SerializeField] private EconomyManager economyManager;

    [SerializeField] private Product product;
    [SerializeField] private Text nameText;
    [SerializeField] private Text priceText;
    [SerializeField] private Text mpsText;
    [SerializeField] private Image productImage;

    private float currentPrice;
    [SerializeField] private float priceMultiplier = 0.01f;
    [SerializeField] private int quantityOwned;

    public Color red;
    public Color green;



    private void Start()
    {
        currentPrice = product.basePrice;
        nameText.text = $"{quantityOwned}x {product.name}";
        priceText.text = $"Price: {currentPrice}";
        mpsText.text = $"MPS: {product.marmeladePerSecond}";
        productImage.sprite = product.image;

        // jos tää on esim eka tuote ja niit on aluks vaik 1
        economyManager.IncreaseMarmeladePerSecond(product.marmeladePerSecond);
    }

    private void Update()
    {
        if (economyManager.currentMarmelade >= currentPrice)
        {
            priceText.color = green;
        }
        else
        {
            priceText.color = red;
        }
    }

    public void BuyProduct() 
    {
        if (economyManager.currentMarmelade >= currentPrice)
        {
            economyManager.SubtractMarmelade((int)currentPrice);
            quantityOwned++;
            economyManager.IncreaseMarmeladePerSecond(product.marmeladePerSecond);
            currentPrice += currentPrice * priceMultiplier;
            nameText.text = $"{quantityOwned}x {product.name}";
            priceText.text = $"Price: {currentPrice}";
        }
    }
    
}
