namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);
            try
            {
                MapLocation[] path = {
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2, map),
                    new MapLocation(7, 2, map),
                };
            }
            catch (OutOfBoundsException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (TreehouseDefenseException e)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            catch (Exception e) 
            {
                Console.WriteLine("Unhandled Exception");
            }
        }
    }
}