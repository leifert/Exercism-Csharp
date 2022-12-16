using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var depart = (department ?? "OWNER").ToUpper();
        return id != null ? $"[{id}] - {name} - {depart}": $"{name} - {depart}";

    }
}
