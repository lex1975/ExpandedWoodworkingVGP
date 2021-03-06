using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;

namespace ExpandedWoodworkingVG
{
	public class Cherry : Plant
	{
		public override void PlantCollected()
		{
			float arg_40_0 = this.def.plant.harvestYield;
			float num = Mathf.InverseLerp(this.def.plant.harvestMinGrowth, 1f, this.growthInt);
			num = 0.5f + num * 0.5f;
			int num2 = GenMath.RoundRandom(arg_40_0 * num * Mathf.Lerp(0.5f, 1f, (float)this.HitPoints / (float)base.MaxHitPoints) * Find.Storyteller.difficulty.cropYieldFactor);
			Thing expr_86 = ThingMaker.MakeThing(ThingDef.Named("WoodLog_Cherry"), null);
			expr_86.stackCount = (int)((float)num2 * 0.5f);
			GenPlace.TryPlaceThing(expr_86, base.Position, base.Map, ThingPlaceMode.Near, null);
			base.PlantCollected();
		}
	}
}
