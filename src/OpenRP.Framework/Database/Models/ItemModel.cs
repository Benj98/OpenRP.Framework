﻿using OpenRP.Framework.Database.Entities;
using OpenRP.Framework.Features.Items.Enums;

namespace OpenRP.Framework.Database.Models
{
    public class ItemModel : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ItemType UseType { get; set; }
        public string UseValue { get; set; }
        public uint Weight { get; set; }
        public uint? MaxUses { get; set; }
        public bool KeepOnDeath { get; set; }
        public bool CanDrop { get; set; }
        public bool CanDestroy { get; set; }
        public bool Stackable { get; set; }
        public int? DropModelId { get; set; }

        // Constructor
        public ItemModel()
        {
            Stackable = true;
        }
    }
}