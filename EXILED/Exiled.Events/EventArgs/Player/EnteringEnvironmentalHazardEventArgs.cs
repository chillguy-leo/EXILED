// -----------------------------------------------------------------------
// <copyright file="EnteringEnvironmentalHazardEventArgs.cs" company="ExMod Team">
// Copyright (c) ExMod Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Events.EventArgs.Player
{
    using Exiled.API.Features.Hazards;
    using Hazards;
    using Interfaces;

    /// <summary>
    /// Contains all information before a player enters in an environmental hazard.
    /// </summary>
    public class EnteringEnvironmentalHazardEventArgs : IPlayerEvent, IDeniableEvent, IHazardEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnteringEnvironmentalHazardEventArgs"/> class.
        /// </summary>
        /// <param name="player"><inheritdoc cref="Player"/></param>
        /// <param name="environmentalHazard"><inheritdoc cref="EnvironmentalHazard"/></param>
        /// <param name="isAllowed"><inheritdoc cref="IsAllowed"/></param>
        public EnteringEnvironmentalHazardEventArgs(API.Features.Player player, EnvironmentalHazard environmentalHazard, bool isAllowed = true)
        {
            Player = player;
            Hazard = Hazard.Get(environmentalHazard);
            IsAllowed = isAllowed;
        }

        /// <summary>
        /// Gets the player who's entering the environmental hazard.
        /// </summary>
        public API.Features.Player Player { get; }

        /// <inheritdoc cref="EnvironmentalHazard"/>
        public Hazard Hazard { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the player should be affected by the environmental hazard.
        /// </summary>
        public bool IsAllowed { get; set; }
    }
}