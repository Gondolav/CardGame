using UnityEngine;
using System.Collections;

/// <summary>
///  To be completed
/// </summary>
public class Building : IFaction
{
	private Unit Unit;
	public bool IsProductionCompleted = false;
	public bool IsHit = false;

	/// <summary>
	///  To be completed
	/// </summary>
	public void Produce() {
		if (!IsHit) {
			int counter = Unit.TimeToProduce;
			if (counter > 0) --counter;
			else IsProductionCompleted = true;
		}
	}

	/// <summary>
	///  To be completed
	/// </summary>
	public void AddUnit(Unit unit) {
		Unit = unit;
	}
}
