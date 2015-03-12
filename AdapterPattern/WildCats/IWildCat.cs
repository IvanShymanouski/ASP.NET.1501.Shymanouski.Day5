namespace AdapterPattern.WildCats
{
    interface IWildCat
    {
        string Breed { get; }
        void Growl();
        void Scratch();
    }
}
