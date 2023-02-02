﻿using TsRandomizer.Randomisation;

namespace TsRandomizer.IntermediateObjects.CustomItems
{
	class ArchipelagoItem : CustomItem
	{
		public override int AnimationIndex => 198;

		public ArchipelagoItem(ItemUnlockingMap unlockingMap) : base(unlockingMap, CustomItemType.Archipelago)
		{
			SetDescription("Item that belongs to a distant timeline somewhere in the Archipelago (cannot be sold)", "Archipelago");
		}
	}
}
