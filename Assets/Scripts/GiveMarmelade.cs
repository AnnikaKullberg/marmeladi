using UnityEngine;

public class GiveMarmelade : MonoBehaviour
{

    [SerializeField] private EconomyManager economyManager;
    [SerializeField] private ParticleSystem particleEffect;

    public float marmeladePerClick;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Marmelade()
    {
        economyManager.AddMarmelade(marmeladePerClick);
        particleEffect.Play();
    }


}
