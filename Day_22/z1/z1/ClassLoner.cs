namespace z1
{
    public class ClassLoner
    {
        private static ClassLoner uniqueInstance;
        public string Name { get; set; }
        private ClassLoner()
        {

        }
        public static ClassLoner GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ClassLoner();
            }
            return uniqueInstance;
        }
    }
}
