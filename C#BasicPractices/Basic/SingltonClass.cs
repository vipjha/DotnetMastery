namespace Basic
{
    public class SingltonClass
    {
        private static SingltonClass instance;

        private SingltonClass() { }

        public static SingltonClass GetInstance()
        {
            if (instance == null)
            {
                instance = new SingltonClass();
            }
            return instance;
        }
    }
}
