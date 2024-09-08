using NUnit.Framework.Constraints;
using UnityEngine;

[System.Serializable]
public class Rows
{
    public GameObject[] cartaElemento;
}
public class CardController : MonoBehaviour
{
    [SerializeField] int cardNum = 0;
    public Rows[] Cards;
    public GameObject cardOnGame;

    // Update is called once per frame
    void Update()
    {
        cardOnGame =  Cards[0].cartaElemento[cardNum];
        if (cardOnGame != null )
        {
            Debug.Log("esto funciona");
        }
    }
    
}
