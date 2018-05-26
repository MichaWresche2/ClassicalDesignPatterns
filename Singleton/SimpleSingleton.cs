namespace ClassicalDesignPatterns
{
    public class SimpleSingleton
    {
        private static SimpleSingleton instance;

        public static SimpleSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SimpleSingleton();
                }

                return instance;
            }
        }

        private SimpleSingleton()
        {

        }
    }
}