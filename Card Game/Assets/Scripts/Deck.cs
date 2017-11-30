using System;
using System.Collections.Generic;

public class Deck
{
	private const int DeckSize = 2;

	private List<Card> cards = new List<Card>(DeckSize);
	public List<Card> Cards
	{
		get
		{
			return cards;
		}

		private set
		{
			cards = value;
		}
	}

	public Deck(List<Card> cards)
	{
		this.Cards = Shuffle(cards);
	}

	public Card Draw()
	{
		var c = Cards[0];
		Cards.RemoveAt(0);
		return c;
	}


	/// <summary>
	///  This method shuffles the given list of cards using R. Durstenfeld's version
	///  of the Fisher-Yates shuffle algorithm.
	/// </summary>
	private static List<Card> Shuffle(IList<Card> list)
	{
		var random = new Random();

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

