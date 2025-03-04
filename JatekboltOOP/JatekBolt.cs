using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatekboltOOP
{
	public class JatekBolt
	{
		public List<Jatek> Jatekok { get; private set; }
		public List<Felhasznalo> Felhasznalok { get; private set; }

		public JatekBolt()
		{
			Jatekok = new List<Jatek>();
			Felhasznalok = new List<Felhasznalo>();
		}

		public void JatekHozzaadas(Jatek jatek)
		{
			Jatekok.Add(jatek);
		}

		public void FelhasznaloHozzaadas(Felhasznalo felhasznalo)
		{
			Felhasznalok.Add(felhasznalo);
		}

		public Jatek KeresJatek(string cim)
		{
			return Jatekok.FirstOrDefault(j => j.Cim == cim);
		}

		public Felhasznalo KeresFelhasznalo(string nev)
		{
			return Felhasznalok.FirstOrDefault(f => f.Nev == nev);
		}
	}

}
