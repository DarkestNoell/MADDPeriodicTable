//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MADDPeriodicTable.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserProgress
    {
        public string Id { get; set; }
        public int CurrentLevel { get; set; }
        public int CurrentPoints { get; set; }
        public int CompoundsCorrect { get; set; }
        public int CompoundsInARow { get; set; }
        public bool NoviceChemistBadge { get; set; }
        public bool ChemistsExplosionBadge { get; set; }
        public bool HotStreakBadge { get; set; }
        public bool SenpaiNoticeMeBadge { get; set; }
        public int VideosWatched { get; set; }
    }
}
