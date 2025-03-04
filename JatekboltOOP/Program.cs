using JatekboltOOP;

class Program
{
	static void Main(string[] args)
	{
		JatekBolt jatekBolt = new JatekBolt();

		jatekBolt.JatekHozzaadas(new Jatek("The Witcher 3", "RPG", 12000));
		jatekBolt.JatekHozzaadas(new Jatek("FIFA 23", "Sport", 18000));
		jatekBolt.JatekHozzaadas(new Jatek("Cyberpunk 2077", "RPG", 15000));

		Felhasznalo adam = new Felhasznalo("Ádám", 20000);
		jatekBolt.FelhasznaloHozzaadas(adam);

		Jatek witcher = jatekBolt.KeresJatek("The Witcher 3");
		adam.Vasarlas(witcher);

		adam.Feltoltes(10000);
		Jatek cyberpunk = jatekBolt.KeresJatek("Cyberpunk 2077");
		adam.Vasarlas(cyberpunk);

		adam.KonyvtarMegtekintes();
	}
}

