﻿using System;
using Timespinner.GameObjects.BaseClasses;
using TsRandomizer.IntermediateObjects;
using TsRandomizer.Screens;
using TsRandomizer.Settings;

namespace TsRandomizer.LevelObjects.Monsters
{
	[TimeSpinnerType("Timespinner.GameObjects.Enemies.TowerPlasmaPod")]
	class TowerPlasmaPod : LevelObject<Monster>
	{
		public TowerPlasmaPod(Monster typedObject, GameplayScreen gameplayScreen) : base(typedObject, gameplayScreen)
		{
		}

		protected override void Initialize(Seed seed, SettingCollection settings) =>
			Dynamic._zapDamage = (int)Math.Ceiling(TypedObject.Damage * 1.25);
	}
}
