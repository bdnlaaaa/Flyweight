using Flyweight;
double x = 0;
double y = 0;
FlyweightFactory factory = new FlyweightFactory();
for (int i = 0; i < 10; i++)
{
    Particle lavender = factory.GetParticle("Lavender");
    if (lavender != null)
        lavender.Create(x, y);
    x += 1;
    y += 1;
}
for (int i = 0; i < 10; i++)
{
    Particle violet = factory.GetParticle("Violet");
    if (violet != null)
        violet.Create(x, y);
    x += 1;
    y += 1;
}