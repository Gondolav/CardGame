using UnityEngine;
using System.Collections;

/// <summary>
///  This class represents buildings which can produce units.
/// </summary>
public class Building : IFaction
{
	private Unit Unit;

	private bool isHit = false;
	public bool IsHit { get; set; }

	private bool isProductionCompleted = false;
	public bool IsProductionCompleted
	{
		get
		{
			return isProductionCompleted;
		}
		private set
		{
			isProductionCompleted = value;
		}

	}

	/// <summary>
	///  This method is used to check if the time necessary to produce a certain unit has elapsed,
	///  and if it is the case it sets the field IsProductionCompleted to true.
	/// </summary>
	public void Produce()
	{
		if (!IsHit)
		{
			int counter = Unit.TimeToProduce;
			if (counter > 0) --counter;
			else IsProductionCompleted = true;
		}
	}

	/// <summary>
	///  This method allows to attach a given unit to the building in order to produce it.
	/// </summary>
	public void AddUnit(Unit unit)
	{
		Unit = unit;
	}
}
