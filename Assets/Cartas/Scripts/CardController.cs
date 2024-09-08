using NUnit.Framework.Constraints;
using UnityEngine;

[System.Serializable]
public class Rows
{
    public GameObject[] cartaElemento;
}
public class CardController : MonoBehaviour
{
   /* [SerializeField] int cardNum = 0;
    public Rows[] Cards;
   */
    public Renderer ColorsCard;
    public Material colorTest;
    public GameObject arma;
    public GameObject armatest;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ShowCard();
        }
    }

    public void ShowCard()
    {
        
        /*
        GameObject temp = Cards[0].cartaElemento[cardNum];
        Instantiate(temp, cardOnGame.transform.position, Quaternion.Euler(0,180,0));
        */ 
        ColorsCard.material = colorTest;
        Instantiate(armatest, arma.transform.position, Quaternion.identity);

    }
    
}
