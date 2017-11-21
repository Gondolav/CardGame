using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  To be completed
/// </summary>
abstract public class Unit : Card, IType {
    private const int DefaultShield = 0;

	private int Attack;
	private int Life;
	private int Shield;
	private bool[] Moves;

    private readonly int timeToProduce;
    public int TimeToProduce {
        get {
            return timeToProduce;
        }
    }

    // we can use Extensions to give enums methods
    private enum UnitType {
        Ground,
        Space
    }

	private Unit(int attack, int life, bool[] moves, int timeToProduce) {
        Utility.Require(attack >= 0, "Attack < 0");
        Utility.Require(life >= 1, "Life <= 0");

        this.Attack = attack;
        this.Life = life;
		this.Shield = DefaultShield;
        this.Moves = moves;
        this.timeToProduce = timeToProduce;
    }
}
