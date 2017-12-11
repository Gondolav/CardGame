using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class represents a deck as a decorator of cards.
/// </summary>
public class Deck : MonoBehaviour
{
	private const int DeckSize = 2;

    void Start() {
        Utility.Require(Cards.Count == DeckSize, "Not enough cards in Deck");
        Cards = Shuffle(Cards);
    }


	public List<Card> Cards = new List<Card>(DeckSize);

	/// <summary>
	/// This method draws a card and returns it.
	/// </summary>
	public Card Draw()
	{
		Card c = Cards[0];
		Cards.RemoveAt(0);
        return c;
	}


	/// <summary>
	///  This method shuffles the given list of cards using R. Durstenfeld's version
	///  of the Fisher-Yates shuffle algorithm.
	/// </summary>
	private static List<Card> Shuffle(IList<Card> list)
	{
		var random = new System.Random();

		var newList = new List<Card>(list);
		int n = newList.Count;
		for (int i = 0; i < n; i++)
		{
			int r = i + random.Next(n - i);
			Card c = newList[r];
			newList[r] = newList[i];
			newList[i] = c;
		}

		return newList;
	}
}

