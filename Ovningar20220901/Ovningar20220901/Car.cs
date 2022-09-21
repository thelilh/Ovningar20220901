namespace Ovningar20220901
{
	public enum Colours
	{
		Röd,
		Vit,
		Blå,
		Grön,
		Svart
	}
	public class Car
	{
		private string _make;
		private int _price;
		private Colours _colour;
		private int _length;

		public Colours Colour
		{
			get { return _colour; }
			set { _colour = value; }
		}


		public int Price
		{
			get
			{
				return _price;
			}
			set
			{
				if (_price > 0)
				{
					if (value <= _price / 2)
					{
						HalfPrice();
					}
				}
				_price = value;
			}
		}


		public string Make
		{
			get { return _make; }
			set { _make = value; }
		}

		public Car()
		{
			Console.WriteLine($"Detta är en bil");
		}
		public Car(string make, int price, Colours colour)
		{
			Make = make;
			Price = price;
			Colour = colour;
		}

		public Car(string make, int price)
		{
			Make = make;
			Price = price;
			var rand = new Random();
			Colour = (Colours)rand.Next(0, 5);
			_length = rand.Next(3, 5);
		}

		public void HalfPrice()
		{
			Console.WriteLine($"Priset på {Make} med färgen {Colour} är nu hälften!");
		}

		public override string ToString()
		{
			return $"Bilen är en {_make}, kostar {_price}, är {_length}m och har färgen {_colour}";
		}
	}
}
