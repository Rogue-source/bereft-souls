using CalamityMod.Items.Materials;
using JetBrains.Annotations;
using SOTS.Items.Permafrost;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BereftCompatibility.Common.Balance;

[UsedImplicitly(ImplicitUseKindFlags.InstantiatedNoFixedConstructorSignature)]
internal sealed class RecipeTweaks : ModSystem
{
    public override void PostAddRecipes()
    {
        base.PostAddRecipes();

        ModifyFrostedKey();
        RemoveModdedRecipes();
    }

    private void ModifyFrostedKey()
    {
        foreach (var recipe in Main.recipe)
        {
            if (recipe.HasResult<FrostedKey>())
            {
                recipe.RemoveIngredient(ItemID.FrostCore);
                recipe.AddIngredient<CryonicBar>(8);
            }
        }
    }

    private void RemoveModdedRecipes()
    {
        foreach (var recipe in Main.recipe)
        {
            if (recipe == null || recipe.createItem?.ModItem == null)
                continue;

            // Adhesive Bandage
            if (recipe.createItem.type == ItemID.AdhesiveBandage &&
                recipe.createItem.ModItem.Mod.Name == "CalamityMod")
            {
				Mod.Logger.Info("Found Adhesive Bandage recipe from CalamityMod, disabling.");
                recipe.DisableRecipe();
            }
			
			if (recipe.createItem.type == ItemID.AdhesiveBandage &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			if (recipe.createItem.type == ItemID.AdhesiveBandage &&
                recipe.createItem.ModItem.Mod.Name == "FargowiltasCrossmod")
            {
                recipe.DisableRecipe();
            }
			
			// Aglet
			if (recipe.createItem.type == ItemID.Aglet &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Armor Polish
			if (recipe.createItem.type == ItemID.ArmorPolish &&
                recipe.createItem.ModItem.Mod.Name == "SOTS")
            {
                recipe.DisableRecipe();
            }
			if (recipe.createItem.type == ItemID.ArmorPolish &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Band of Regeneration
			if (recipe.createItem.type == ItemID.BandofRegeneration &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Band of Starpower
			if (recipe.createItem.type == ItemID.BandofStarpower &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Bezoar
			if (recipe.createItem.type == ItemID.Bezoar &&
                recipe.createItem.ModItem.Mod.Name == "SOTS")
            {
                recipe.DisableRecipe();
            }
			if (recipe.createItem.type == ItemID.Bezoar &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Blindfold
			if (recipe.createItem.type == ItemID.Blindfold &&
                recipe.createItem.ModItem.Mod.Name == "CalamityMod")
            {
                recipe.DisableRecipe();
            }
			if (recipe.createItem.type == ItemID.Blindfold &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Blizzard in a bottle
			if (recipe.createItem.type == ItemID.BlizzardinaBottle &&
				recipe.createItem.ModItem == null)
			{
				recipe.DisableRecipe();
			}
			if (recipe.createItem.type == ItemID.BlizzardinaBottle &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Celestial Emblem
			if (recipe.createItem.type == ItemID.CelestialEmblem &&
				recipe.createItem.ModItem == null)
			{
				recipe.DisableRecipe();
			}
			
			// Celestial Magnet
			if (recipe.createItem.type == ItemID.CelestialMagnet &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Cloud in a bottle
			if (recipe.createItem.type == ItemID.CloudinaBottle &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Cobalt Shield
			if (recipe.createItem.type == ItemID.CobaltShield &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Fast Clock
			if (recipe.createItem.type == ItemID.FastClock &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			if (recipe.createItem.type == ItemID.FastClock &&
                recipe.createItem.ModItem.Mod.Name == "CalamityMod")
            {
                recipe.DisableRecipe();
            }
			
			// Feral Claws
			if (recipe.createItem.type == ItemID.FeralClaws &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Flame Waker Boots
			if (recipe.createItem.type == ItemID.FlameWakerBoots &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Fledgling Wings
			if (recipe.createItem.type == ItemID.CreativeWings &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Flesh Knuckles
			if (recipe.createItem.type == ItemID.FleshKnuckles &&
                recipe.createItem.ModItem.Mod.Name == "CalamityMod")
            {
                recipe.DisableRecipe();
            }
			
			// Flipper
			if (recipe.createItem.type == ItemID.Flipper &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			if (recipe.createItem.type == ItemID.Flipper &&
                recipe.createItem.ModItem.Mod.Name == "FargowiltasCrossmod")
            {
                recipe.DisableRecipe();
            }
			
			// Flower Boots
			if (recipe.createItem.type == ItemID.FlowerBoots &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			if (recipe.createItem.type == ItemID.FlowerBoots &&
                recipe.createItem.ModItem.Mod.Name == "CalamityMod")
            {
                recipe.DisableRecipe();
            }
			
			// Flying Carpet
			if (recipe.createItem.type == ItemID.FlyingCarpet &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Frozen Turtle Shell
			if (recipe.createItem.type == ItemID.FrozenTurtleShell &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Guide Voodoo Doll
			if (recipe.createItem.type == ItemID.GuideVoodooDoll &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			if (recipe.createItem.type == ItemID.GuideVoodooDoll &&
                recipe.createItem.ModItem.Mod.Name == "CalamityMod")
            {
                recipe.DisableRecipe();
            }
			
			// Guide Doll and Match Kit
			if (recipe.createItem.type == ModContent.ItemType<Fargowiltas.Items.Summons.Mutant.FleshyDoll>() &&
			recipe.createItem.ModItem?.Mod?.Name == "Fargowiltas")
			{
				recipe.DisableRecipe();
			}

			
			// Hand Warmer
			if (recipe.createItem.type == ItemID.HandWarmer &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Hermes Boots
			if (recipe.createItem.type == ItemID.HermesBoots &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Ice Skates
			if (recipe.createItem.type == ItemID.IceSkates &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Jellyfish Necklace
			if (recipe.createItem.type == ItemID.JellyfishNecklace &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			if (recipe.createItem.type == ItemID.JellyfishNecklace &&
                recipe.createItem.ModItem.Mod.Name == "FargowiltasCrossmod")
            {
                recipe.DisableRecipe();
            }
			
			// Lava Charm
			if (recipe.createItem.type == ItemID.LavaCharm &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Lavaproof Fishing Hook
			if (recipe.createItem.type == ItemID.LavaFishingHook &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Lucky Horseshoe
			if (recipe.createItem.type == ItemID.LuckyHorseshoe &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Machina Booster
			if (recipe.createItem.ModItem?.Mod?.Name == "SOTS" &&
			recipe.createItem.Name == "MachinaBooster" &&
			recipe.requiredTile.Contains(ModContent.TileType<SOTS.Items.Planetarium.Furniture.HardlightFabricatorTile>()))
			{
				recipe.DisableRecipe();
			}
			
			// Magic Quiver
			if (recipe.createItem.type == ItemID.MagicQuiver &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Mechanical Glove
			if (recipe.createItem.type == ItemID.MechanicalGlove &&
				recipe.createItem.ModItem == null)
			{
				recipe.DisableRecipe();
			}
			
			// Megaphone
			if (recipe.createItem.type == ItemID.Megaphone &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			if (recipe.createItem.type == ItemID.Megaphone &&
                recipe.createItem.ModItem.Mod.Name == "CalamityMod")
            {
                recipe.DisableRecipe();
            }
			
			// Metal Detector
			if (recipe.createItem.type == ItemID.MetalDetector &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Nazar
			if (recipe.createItem.type == ItemID.Nazar &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			if (recipe.createItem.type == ItemID.Nazar &&
                recipe.createItem.ModItem.Mod.Name == "CalamityMod")
            {
                recipe.DisableRecipe();
            }
			
			// Obsidian Rose
			if (recipe.createItem.type == ItemID.ObsidianRose &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Panic Necklace
			if (recipe.createItem.type == ItemID.PanicNecklace &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Pocket Mirror
			if (recipe.createItem.type == ItemID.PocketMirror &&
                recipe.createItem.ModItem.Mod.Name == "Fargowiltas")
            {
                recipe.DisableRecipe();
            }
			
			// Putrid Scent
			if (recipe.createItem.type == ItemID.PutridScent &&
                recipe.createItem.ModItem.Mod.Name == "CalamityMod")
            {
                recipe.DisableRecipe();
            }
        }
    }
}
