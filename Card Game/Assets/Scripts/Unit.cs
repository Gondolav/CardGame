using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Unit : Card, Type {
    private int attack;
    private int life;
    private int shield;
    private bool[] moves;

    private enum UnitType {
        Ground,
        Space
    }

    private readonly int timeToProduce;

    private Unit(int attack, int life, bool[] moves, int timeToProduce) {
        this.attack = attack;
        this.life = life;
        this.shield = 0;
        this.moves = moves;
        this.timeToProduce = timeToProduce;
    }
}
