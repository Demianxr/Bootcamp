﻿using System.Text.Json.Serialization;

namespace Core.Request;

public class CreatePromotionModel
{
    public string Name { get; set; } = string.Empty;
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public int Discount { get; set; }

    public List<int> RelatedEnterpriseIds { get; set; } = new List<int>();
}