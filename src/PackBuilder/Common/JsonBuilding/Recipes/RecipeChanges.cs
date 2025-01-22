﻿using PackBuilder.Content.JsonBuilding.Recipes.Changes;
using System;
using System.Collections.Generic;
using Terraria;

namespace PackBuilder.Content.JsonBuilding.Recipes;

// The change(s) that will be applied to each of the recipes where conditions are met.

internal class RecipeChanges
{
    public List<RecipeChange> Changes = [];

    // All of these are available as set only properties so that the json parser
    // can continually build a list by specifying the same property multiple times.
    //
    // Although there may be better ways to do this for strictly programming, doing it
    // this way creates the cleaniest, most intuitive, and easiest implementation
    // for creating json files.

    public AddIngredient AddIngredient { set => Changes.Add(value); }
    public ChangeIngredient ChangeIngredient { set => Changes.Add(value); }
    public ChangeResult ChangeResult { set => Changes.Add(value); }
    public RemoveIngredient RemoveIngredient { set => Changes.Add(value); }

    /// <summary>
    /// Applies this <see cref="RecipeChanges"/> set to a given recipe.
    /// </summary>
    public void ApplyTo(Recipe recipe)
    {
        if (Changes.Count == 0)
            throw new MissingFieldException("Must specify 1 or more changes for a recipe modification!", nameof(Changes));

        foreach (var change in Changes)
            change.ApplyTo(recipe);
    }
}