using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatekboltOOP
{
	public class Felhasznalo
	{
		public string Nev { get; private set; }
		public int Egyenleg { get; private set; }
		public List<Jatek> Konyvtar { get; private set; }

		public Felhasznalo(string nev, int egyenleg)
		{
			Nev = nev;
			Egyenleg = egyenleg;
			Konyvtar = new List<Jatek>();
		}

		public bool Vasarlas(Jatek jatek)
		{
			if (Konyvtar.Contains(jatek))
			{
				Console.WriteLine("A játék már megvan a könyvtárban.");
				return false;
			}

			if (Egyenleg >= jatek.Ar)
			{
				Egyenleg -= jatek.Ar;
				Konyvtar.Add(jatek);
				Console.WriteLine($"{jatek.Cim} sikeresen megvásárolva!");
				return true;
			}
			else
			{
				Console.WriteLine("Nincs elég pénz a vásárláshoz.");
				return false;
			}
		}

		public void KonyvtarMegtekintes()
		{
			Console.WriteLine("Megvásárolt játékok:");
			foreach (var jatek in Konyvtar)
			{
				Console.WriteLine($"- {jatek.Cim}");
			}
		}

		public void Feltoltes(int osszeg)
		{
			Egyenleg += osszeg;
			Console.WriteLine($"Egyenleg feltöltve: +{osszeg} Ft");
		}
	}

}
