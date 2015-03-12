namespace AdapterPattern.HomeCats
{
    interface IHomeCat
    {
        string Name { get; set; }
        void Meow();
        void Scratch();
    }
}
