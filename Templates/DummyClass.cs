namespace T4Box
{
    class DummyClass
    {
        private readonly int _value;

        public DummyClass()
        {
            _value = 5;
        }

        public int Value
        {
            get
            {
                return _value;
            }
        }
    }
}
