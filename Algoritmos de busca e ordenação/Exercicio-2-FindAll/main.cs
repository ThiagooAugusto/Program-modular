using System;

public class DinoDiscoverySet
{
    public static void Main()
    {
        string busca;
        string[] dinosaurs =
        {
            "Compsognathus", "Amargasaurus", "Oviraptor","Troodon",
            "Velociraptor",  "Deinonychus",  "Dilophosaurus","Achelousaurus",
            "Gallimimus",    "Triceratops","Amargarantius","Omeisaurus"
        };

        DinoDiscoverySet GoMesozoic = new DinoDiscoverySet(dinosaurs);
        Console.WriteLine("Digite um prefixo a buscar:");
        busca = Console.ReadLine();
        GoMesozoic.DiscoverAll();
        GoMesozoic.DiscoverByBeggining(busca.ToLower());
    }

    private string[] dinosaurs;

    public DinoDiscoverySet(string[] items)
    {
        dinosaurs = items;
    }

    public void DiscoverAll()
    {
        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }
    }

    public void DiscoverByBeggining(string prefixo)
    {

        Console.WriteLine(
            "\nArray.FindAll(dinosaurs, \"{0}\"):", prefixo);

        string[] subArray =
            Array.FindAll(dinosaurs, s => s.StartsWith(prefixo));

        foreach (string dinosaur in subArray)
        {
            Console.WriteLine(dinosaur);
        }
    }
}