using UnityEngine;

public class CardManager : MonoBehaviour
{
    public Transform cardContainer; 
    public GameObject[] cardPrefabs; 
    private GameObject currentCard; 
    public int currentIndex = 0;

    void Start()
    {
        
        ShowCard(currentIndex);
    }

   
    public void ShowCard(int index)
    {
        
        if (currentCard != null)
        {
            Destroy(currentCard);
        }

        
        if (index >= 0 && index < cardPrefabs.Length)
        {
            
            currentCard = Instantiate(cardPrefabs[index], cardContainer.position, cardPrefabs[index].transform.rotation);
        }
    }

   
    public void NextCard()
    {
        currentIndex++;
        if (currentIndex >= cardPrefabs.Length)
        {
            currentIndex = 0; 
        }
        ShowCard(currentIndex);
    }

    
    public void PreviousCard()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = cardPrefabs.Length - 1; 
        }
        ShowCard(currentIndex);
    }
}
