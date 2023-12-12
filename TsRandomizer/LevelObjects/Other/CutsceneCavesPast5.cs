﻿using System.Collections.Generic;
using Timespinner.GameAbstractions.Gameplay;
using Timespinner.GameAbstractions.HUD;
using Timespinner.GameObjects.BaseClasses;
using TsRandomizer.Extensions;
using TsRandomizer.IntermediateObjects;
using TsRandomizer.Randomisation;
using TsRandomizer.Screens;
using TsRandomizer.Settings;

namespace TsRandomizer.LevelObjects.Other
{
	[TimeSpinnerType("Timespinner.GameObjects.Events.Cutscene.CutsceneCavesPast5")]
	class CutsceneCavesPast5 : LevelObject
	{
		public CutsceneCavesPast5(Mobile typedObject, GameplayScreen gameplayScreen) : base(typedObject, gameplayScreen)
		{
		}

		protected override void Initialize(Seed seed, SettingCollection settings)
		{
			bool isRandomized = Level.GameSave.GetSettings().BossRando.Value != "Off";
			if (!isRandomized)
				return;

			BossAttributes vanillaBoss = BestiaryManager.GetBossAttributes(Level, Level.GameSave.GetSaveInt("VanillaBossId"));
			if (vanillaBoss.Index != (int)EBossID.Prince && vanillaBoss.Index != (int)EBossID.Vol)
				return;

			Dynamic.SilentKill();

			//abort already triggered scripts
			((List<ScriptAction>)LevelReflected._activeScripts).Clear();
			((Queue<DialogueBox>)LevelReflected._dialogueQueue).Clear();
			((Queue<ScriptAction>)LevelReflected._waitingScripts).Clear();
		}

		protected override void OnUpdate()
		{
		}
	}
}

