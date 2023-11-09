public class RegiaoDeInteresseModel
{
  public string Estado { get; set; }
  public string Sigla { get; set; }
  public string Regiao { get; set; }

  public static List<RegiaoDeInteresseModel> GetRegiaoDeInteresses()
  {
    return new List<RegiaoDeInteresseModel>
        {
          { new RegiaoDeInteresseModel(){ Estado = "São Paulo" , Sigla = "sp" ,
          Regiao = "A" } },
          { new RegiaoDeInteresseModel(){ Estado = "São Paulo" , Sigla = "sp" ,
          Regiao = "B"}},
          { new RegiaoDeInteresseModel(){ Estado = "São Paulo" , Sigla = "sp" ,
          Regiao = "C"}},
          { new RegiaoDeInteresseModel(){ Estado = "São Paulo" , Sigla = "sp" ,
          Regiao = "D"}},
          { new RegiaoDeInteresseModel(){ Estado = "Minas Gerais" , Sigla = "mg" ,
          Regiao = "E" } },
          { new RegiaoDeInteresseModel(){ Estado = "Pernambuco" , Sigla = "pe" ,
          Regiao = "F" } },
          { new RegiaoDeInteresseModel(){ Estado = "Pernambuco" , Sigla = "pe" ,
          Regiao = "G" } },
          { new RegiaoDeInteresseModel(){ Estado = "Pernambuco" , Sigla = "pe" ,
          Regiao = "H" } },
          { new RegiaoDeInteresseModel(){ Estado = "Pernambuco" , Sigla = "pe" ,
          Regiao = "I" } },
          { new RegiaoDeInteresseModel(){ Estado = "Paraná" , Sigla = "pr" , Regiao
          = "J" } },
          { new RegiaoDeInteresseModel(){ Estado = "Paraná" , Sigla = "pr" , Regiao
          = "K" } },
          { new RegiaoDeInteresseModel(){ Estado = "Paraná" , Sigla = "pr" , Regiao
          = "L" } },
        };
  }
}