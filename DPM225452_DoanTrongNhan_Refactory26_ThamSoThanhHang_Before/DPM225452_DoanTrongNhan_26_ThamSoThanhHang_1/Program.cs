double PotentialEnergy(double mass, double height)
{
    return Math.Round(mass * height * 9.81, 2);
}
Random rand = new Random();
double m = Math.Round(rand.NextDouble() * (100 - 1) + 1, 2);
double h = Math.Round(rand.NextDouble() * (100 - 1) + 1, 2);
Console.WriteLine("PotentialEnergy(" + m+ "; "+ h +") = "+PotentialEnergy(m, h));