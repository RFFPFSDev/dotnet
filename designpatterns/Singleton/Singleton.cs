namespace Singleton;

public class Singleton
{
    private static Singleton _instance;

    // Make the default constructor private, to prevent other objects from using the new operator with the Singleton class.
    private Singleton()
    {
    }

    // Create a static creation method that acts as a constructor.
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }

        return _instance;
    }
}
