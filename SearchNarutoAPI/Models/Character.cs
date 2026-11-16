public class ApiResponse
{
    public List<Character>? Characters { get; set; }
}

public class Character
{
    public int? Id { get; set; }
    public string? Name { get; set; } // Nome do personagem
    public List<string>? Images { get; set; } // Lista de URLs de imagem
    public PersonalInfo? Personal { get; set; } // Clã ou Afiliação do personagem
    public List<string>? Jutsu { get; set; } // Lista dos jutsus do personagem
    public RankInfo? Rank { get; set; } // Patente ninja
}

public class PersonalInfo
{
    public string? Clan { get; set; }
    public string? Affiliation { get; set; }
}

public class RankInfo
{
    public string? NinjaRank { get; set; }
}