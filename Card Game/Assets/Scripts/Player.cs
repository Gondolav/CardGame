using System.Collections.Generic;
using System;

/// <summary>
///  This class represents a player with a certain deck and a certain faction.
/// </summary>
public class Player {
    private List<Card> deck = new List<Card>(2);
    private IFaction faction;

    public Player(List<Card> deck, IFaction faction) {
        this.deck = Shuffle(deck);
        this.faction = faction;
    }

    /// <summary>
    ///  This method returns a card drawn from the deck.
    /// </summary>
    public Card Draw() {
        Card c = deck[0];
        deck.RemoveAt(0);
        return c;
    }

    /// <summary>
    ///  This method shuffles the given list of cards using R. Durstenfeld's version
    ///  of the Fisher-Yates shuffle algorithm.
    /// </summary>
    private static List<Card> Shuffle(IList<Card> list) {
        Random random = new Random();

        List<Card> newList = new List<Card>(list);
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
