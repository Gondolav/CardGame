using System.Collections.Generic;
using System;

/// <summary>
///  To be completed
/// </summary>
public class Player {
    private List<Card> deck = new List<Card>(2);
    private IFaction faction;

    public Player(List<Card> deck, IFaction faction) {
        this.deck = Shuffle(deck);
        this.faction = faction;
    }

    /// <summary>
    ///  To be completed
    /// </summary>
    public Card Draw() {
        Card c = deck[0];
        deck.RemoveAt(0);
        return c;
    }

    /// <summary>
    ///  To be completed
    /// </summary>
    private List<Card> Shuffle(IList<Card> list) {
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
