using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BurnZone : MonoBehaviour, IDropHandler
{
    public AudioSource burnAudio = null;

    public void OnDrop(PointerEventData eventData)
    {        
        Debug.Log("Card is in Burn Zone");

        GameObject obj = eventData.pointerDrag;
        Card card = obj.GetComponent<Card>();
        if (card!=null)
        {
            GameController.instance.playersHand.RemoveCard(card);
        }
    }
}
