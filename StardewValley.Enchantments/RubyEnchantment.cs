using System;
using StardewValley.GameData.Weapons;
using StardewValley.Tools;

namespace StardewValley.Enchantments;

public class RubyEnchantment : BaseWeaponEnchantment
{
	protected override void _ApplyTo(Item item)
	{
		base._ApplyTo(item);
		if (item is MeleeWeapon weapon)
		{
			WeaponData weaponData = Game1.weaponData[weapon.ItemId];
			int baseMin = weaponData.MinDamage;
			int baseMax = weaponData.MaxDamage;
			weapon.minDamage.Value += Math.Max(1, (int)((float)baseMin * 0.1f)) * GetLevel();
			weapon.maxDamage.Value += Math.Max(1, (int)((float)baseMax * 0.1f)) * GetLevel();
		}
	}

	protected override void _UnapplyTo(Item item)
	{
		base._UnapplyTo(item);
		if (item is MeleeWeapon weapon)
		{
			WeaponData weaponData = Game1.weaponData[weapon.ItemId];
			int baseMin = weaponData.MinDamage;
			int baseMax = weaponData.MaxDamage;
			weapon.minDamage.Value -= Math.Max(1, (int)((float)baseMin * 0.1f)) * GetLevel();
			weapon.maxDamage.Value -= Math.Max(1, (int)((float)baseMax * 0.1f)) * GetLevel();
		}
	}

	public override bool ShouldBeDisplayed()
	{
		return false;
	}

	public override bool IsForge()
	{
		return true;
	}
}
