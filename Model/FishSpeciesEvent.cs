﻿using Model.Abstactions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public partial class FishSpeciesEvent : Event
{
    public long FishSpeciesId { get; set; }

    [ForeignKey(nameof(FishSpeciesId))]
    public FishSpecies? FishSpecies { get; set; }
}