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
		private string _colour;

		public string Colour
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
		public Car(string make, int price, string colour)
		{
			Make = make;
			Price = price;
			Colour = colour;
		}

		public Car(string make, int price)
		{
			Make = make;
			Price = price;
			Random rand = new Random();
			var randomColour = (Colours)rand.Next(0, 5);
			Colour = randomColour switch
			{
				Colours.Blå => "Blå",
				Colours.Grön => "Grön",
				Colours.Röd => "Röd",
				Colours.Svart => "Svart",
				Colours.Vit => "Vit",
				_ => "Regnbågsfärgad" //Likväl en regnbågsfärgad bil, bör detta var omöjligt!
			};
		}

		public void HalfPrice()
		{
			Console.WriteLine($"Priset på {Make} med färgen {Colour} är nu hälften!");
		}

		public override string ToString()
		{
			return $"Bilen är en {_make}, kostar {_price} och har färgen {_colour}";
		}
	}
}
