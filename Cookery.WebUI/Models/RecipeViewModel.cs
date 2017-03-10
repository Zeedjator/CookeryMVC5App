﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cookery.Domain;

namespace Cookery.WebUI.Models
{
    public class RecipeViewModel
    {
        public Recipe Recipe { get; set; }
        public string IngredientsList { get; set; }
    }
}