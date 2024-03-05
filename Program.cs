using SevenWonders;
namespace SevenWondersApp

{
    public class Program
    {
        static void Main(string[] args)
        {
            GreatPyramid greatPyramid = new GreatPyramid();
            HangingGardens hangingGardens = new HangingGardens();
            StatueOfZeus statueOfZeus = new StatueOfZeus();
            TempleOfArtemis templeOfArtemis = new TempleOfArtemis();
            Mausoleum mausoleum = new Mausoleum();
            ColossusOfRhodes colossusOfRhodes = new ColossusOfRhodes();
            LighthouseOfAlexandria lighthouseOfAlexandria = new LighthouseOfAlexandria();

            Console.WriteLine($"1. {greatPyramid.Name} ({greatPyramid.Location}): {greatPyramid.Description}");
            Console.WriteLine($"2. {hangingGardens.Name} ({hangingGardens.Location}): {hangingGardens.Description}");
            Console.WriteLine($"3. {statueOfZeus.Name} ({statueOfZeus.Location}): {statueOfZeus.Description}");
            Console.WriteLine($"4. {templeOfArtemis.Name} ({templeOfArtemis.Location}): {templeOfArtemis.Description}");
            Console.WriteLine($"5. {mausoleum.Name} ({mausoleum.Location}): {mausoleum.Description}");
            Console.WriteLine($"6. {colossusOfRhodes.Name} ({colossusOfRhodes.Location}): {colossusOfRhodes.Description}");
            Console.WriteLine($"7. {lighthouseOfAlexandria.Name} ({lighthouseOfAlexandria.Location}): {lighthouseOfAlexandria.Description}");
        }
    }
}
