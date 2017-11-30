using System.Collections.Generic;
using System;

/// <summary>
///  This class represents a player with a deck, a hand of cards and a certain faction.
/// </summary>
public class Player
{
	private const int HandSize = 2;
	private const int InitialCredit = 0;
	private const int NewTurnCredit = 1;

	private readonly Deck Deck;

	private List<Card> Hand = new List<Card>(HandSize);
	private List<Unit> Units = new List<Unit>();

	private IFaction Faction;

	private int credit;
	public int Credit
	{
		get
		{
			return credit;
		}
		private set
		{
			credit = value;
		}
	}

	private bool end;
	public bool End
	{
		get
		{
			return end;
		}
		private set
		{
			end = value;
		}

	}

	private bool HasDrawn;
	private bool CanInitiate;

	public Player(Deck deck, IFaction faction)
	{
		Utility.Require(deck != null, "Deck == null");
		this.Deck = deck;
		this.Faction = faction;
		this.Credit = InitialCredit;
		this.End = false;
		this.HasDrawn = false;
		this.CanInitiate = false;
	}

	public void TakeAwayPermissions()
	{
		CanInitiate = false;
	}

	public void GivePermissions()
	{
		HasDrawn = false;
		End = false;

		CanInitiate = true;
	}

	public void GenerateCredit()
	{
		Credit += NewTurnCredit;

		foreach (Unit unit in Units)
		{
			if (unit.InEnemyLand) Credit += 1; /// replace 1 with unit score attribute
		}
	}

	public void Update()
	{
		if (!HasDrawn)
		{
			Draw();
		}
	}

	/// <summary>
	///  This method draws a card from the deck and adds it to the hand of the player.
	/// </summary>
	private void Draw()
	{
		Hand.Add(Deck.Draw());
		HasDrawn = true;
	}
}
