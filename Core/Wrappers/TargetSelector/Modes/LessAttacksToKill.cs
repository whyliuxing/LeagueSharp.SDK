﻿// <copyright file="LessAttacksToKill.cs" company="LeagueSharp">
//    Copyright (c) 2015 LeagueSharp.
// 
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
// 
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
// 
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see http://www.gnu.org/licenses/
// </copyright>

namespace LeagueSharp.SDK.Core.Wrappers.TargetSelector.Modes
{
    using System.Collections.Generic;
    using System.Linq;

    using LeagueSharp.SDK.Core.UI.IMenu;
    using LeagueSharp.SDK.Core.Wrappers.Damages;

    /// <summary>
    ///     The less attacks to kill Mode.
    /// </summary>
    public class LessAttacksToKill : ITargetSelectorMode
    {
        #region Public Properties

        /// <summary>
        ///     The display name
        /// </summary>
        public string DisplayName => "Less Attacks To Kill";

        /// <summary>
        ///     The name
        /// </summary>
        public string Name => "less-attacks-to-kill";

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Adds to menu.
        /// </summary>
        /// <param name="menu">The menu.</param>
        public void AddToMenu(Menu menu) {}

        /// <summary>
        ///     Orders the champions.
        /// </summary>
        /// <param name="heroes">The heroes.</param>
        /// <returns></returns>
        public List<Obj_AI_Hero> OrderChampions(List<Obj_AI_Hero> heroes)
        {
            return heroes.OrderBy(x => x.Health / GameObjects.Player.GetAutoAttackDamage(x)).ToList();
        }

        #endregion
    }
}